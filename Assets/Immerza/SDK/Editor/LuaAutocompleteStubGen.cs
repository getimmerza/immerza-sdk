using CSObjectWrapEditor;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using XLua;

public static class LuaAutocompleteStubGen
{
    const string tmpl = @"
<%
  -- Scaffold parent namespaces (e.g., CS.ImmerzaSDK)
  local parts = {}
  for part in string.gmatch(cls, '[^%.]+') do table.insert(parts, part) end
  if #parts > 1 then
    local prefix = ''
    for i = 1, #parts - 1 do
      prefix = prefix .. (i > 1 and '.' or '') .. parts[i]
      %>CS.<%= prefix %> = CS.<%= prefix %> or {}<%
    end
  end
%>
---@class CS.<%= cls %>
CS.<%= cls %> = CS.<%= cls %> or {}
<% for _, m in ipairs(methods) do %>
  <% if m.isEvent then %>
---@param op string
---@param callback function
function CS.<%= cls %>.<%= m.name %>(op, callback) end

  <% else %>
  <% for _, p in ipairs(m.params) do %>---@param <%= p.name %> <%= p.type %><% end %>
  <% if m.ret then %>---@return <%= m.ret %><% end %>
  <% if m.static then %>
function CS.<%= cls %>.<%= m.name %>(<%= table.concat(m.paramNames, ', ') %>) end
  <% else %>
function CS.<%= cls %>:<%= m.name %>(<%= table.concat(m.paramNames, ', ') %>) end
  <% end %>

  <% end %>
<% end %>";

    [MenuItem("XLua/Gen Lua Autocompletion Stubs")]
    public static void Gen()
    {
        Generator.CustomGen(tmpl, GetTasks);
        AssetDatabase.Refresh();
    }

    static IEnumerable<CustomGenTask> GetTasks(LuaEnv env, UserConfig cfg)
    {
        foreach (var t in cfg.LuaCallCSharp)
        {
            var data = env.NewTable();
            string clsFull = string.IsNullOrEmpty(t.Namespace) ? t.Name : $"{t.Namespace}.{t.Name}";
            data.Set("cls", clsFull);

            var methodsLua = env.NewTable();
            var methodsList = t.GetMethods()
                                .Where(mi => !mi.IsSpecialName)
                                .ToArray();


            int i = 0;
            for (; i < methodsList.Length; i++)
            {
                var mi = methodsList[i];
                var mtab = env.NewTable();

                var retType = mi.ReturnType != typeof(void) ? mi.ReturnType.Name : null;
                mtab.Set("ret", retType);

                mtab.Set("static", mi.IsStatic);

                var ps = mi.GetParameters();
                var paramNamesLua = env.NewTable();
                var paramsLua = env.NewTable();

                for (int pi = 0; pi < ps.Length; pi++)
                {
                    var p = ps[pi];
                    paramNamesLua.Set(pi + 1, p.Name);
                    var paramTab = env.NewTable();
                    paramTab.Set("name", p.Name);
                    paramTab.Set("type", p.ParameterType.Name);
                    paramsLua.Set(pi + 1, paramTab);
                }

                mtab.Set("paramNames", paramNamesLua);
                mtab.Set("params", paramsLua);
                mtab.Set("name", mi.Name);

                methodsLua.Set(i + 1, mtab);
            }

            foreach (var ev in t.GetEvents(BindingFlags.Public | BindingFlags.Static))
            {
                var mtab = env.NewTable();
                mtab.Set("name", ev.Name);
                mtab.Set("static", true);
                mtab.Set("isEvent", true);
                methodsLua.Set(i++, mtab);
            }

            data.Set("methods", methodsLua);

            var dir = Path.Combine(Application.dataPath, "Immerza", "LuaAutocompletion");
            Directory.CreateDirectory(dir);
            var path = Path.Combine(dir, clsFull + ".lua");

            yield return new CustomGenTask
            {
                Data = data,
                Output = new StreamWriter(path, false, Encoding.UTF8)
            };
        }
    }
}
