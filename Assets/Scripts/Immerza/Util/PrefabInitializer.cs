using ImmerzaSDK.Types;
using System.Collections.Generic;
using UnityEngine;

namespace ImmerzaSDK.Util
{
    public class PrefabInitializer : MonoBehaviour
    {
        private List<ComponentData> components = new List<ComponentData>();

        public void SetComponents(List<ComponentData> components) { this.components = components; }

        public List<ComponentData> GetComponents() { return components; }
    }
}
