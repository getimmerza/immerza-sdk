using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using XLua;

namespace ImmerzaSDK.Wrappers
{
    [LuaCallCSharp]
    public static class NeckDataService
    {
#if !IMMERZA_INTERNAL
#pragma warning disable CS1998
#endif
        public static async void SendNeckData(NeckDataWrapper data)
        {
#if IMMERZA_INTERNAL
        AuthData authData = await AuthManager.Instance.GetAuthData();

        string reqContent = JsonConvert.SerializeObject(data);

        using UnityWebRequest neckDataReq = UnityWebRequest.Post(Constants.BaseApiUrl + "/fhir/Observation", reqContent, "application/json");
        neckDataReq.SetRequestHeader("Authorization", authData.accessToken);
        await neckDataReq.SendWebRequest();

        if (neckDataReq.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError(neckDataReq.downloadHandler.text);
        }
#endif
        }
    }

    [LuaCallCSharp]
    public class NeckDataWrapper
    {
        public string status { get; set; }
        public string code { get; set; }
        public DateTime effectiveDateTime { get; set; }
        public Subject subject { get; set; }
        public Device device { get; set; }
        public List<Component> components { get; set; } = new List<Component>();

        public void SetStatus(string status) => this.status = status;
        public void SetCode(string code) => this.code = code;
        public void SetEffectiveDateTime(DateTime datetime) => effectiveDateTime = datetime;

        public void SetSubject(string id, string type)
        {
            subject = new Subject { id = id, type = type };
        }

        public void SetDevice(string id, string type)
        {
            device = new Device { id = id, type = type };
        }

        public void AddComponent(string code, string quantityType, string value)
        {
            components.Add(new Component
            {
                code = code,
                measurement = new Measurement
                {
                    type = quantityType,
                    value = value
                }
            });
        }
    }

    [LuaCallCSharp]
    public class Subject
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    [LuaCallCSharp]
    public class Device
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    [LuaCallCSharp]
    public class Component
    {
        public string code { get; set; }
        public Measurement measurement { get; set; }
    }

    [LuaCallCSharp]
    public class Measurement
    {
        public string type { get; set; }
        public string value { get; set; }
    }
}