using System.Collections.Generic;
using System;
using UnityEngine;

namespace ImmerzaSDK.Shared
{
    [CreateAssetMenu(menuName = "ImmerzaSDK/Events/NeckDataEventChannel")]
    public class NeckDataEventChannel : ScriptableObject
    {
        public event Action<NeckDataWrapper> OnNeckDataRaised;

        public void Raise(NeckDataWrapper data)
        {
            OnNeckDataRaised?.Invoke(data);
        }
    }

    public class NeckDataWrapper
    {
        public string status { get; set; }
        public string code { get; set; }
        public DateTime effectiveDateTime { get; set; }
        public object subject { get; set; }
        public object device { get; set; }
        public List<object> components { get; set; } = new List<object>();

        public void SetStatus(string status) => this.status = status;
        public void SetCode(string code) => this.code = code;
        public void SetEffectiveDateTime(DateTime datetime) => effectiveDateTime = datetime;

        public void SetSubject(string id, string type)
        {
            subject = new { id = id, type = type };
        }

        public void SetDevice(string id, string type)
        {
            device = new { id = id, type = type };
        }

        public void AddComponent(string code, string quantityType, string value)
        {
            components.Add(
            new
            {
                code,
                measurement = new
                {
                    type = quantityType,
                    value
                }
            });
        }
    }
}
