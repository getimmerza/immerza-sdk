using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace ImmerzaSDK.Util
{
    internal class ImmerzaUtil
    {
        public static string GetHierarchyPath(GameObject obj)
        {
            string path = "/" + obj.name;
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }

            return path;
        }
    }
}
