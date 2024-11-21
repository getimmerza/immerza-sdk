using System.Collections.Generic;
using UnityEngine;


public class TestBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject movingCube = null;

    [SerializeField]
    private Light movingLight = null;

    [SerializeField]
    private float baseIntensity;

    [SerializeField]
    private string stringTest = "Hello";

    /*[SerializeField] private List<int> testListInt = new();

    [SerializeField] private List<string> testListString = new();
    [SerializeField] private string[] testArrayString;
    [SerializeField] private float[] testArrayPrimitive;
    [SerializeField] private List<Light> testListReferences = new();
    [SerializeField] private MeshRenderer[] testArrayReferences;*/

    [SerializeField] private List<Material> testAssetReferences = new();
    [SerializeField] private List<GameObject> testGOReferences = new();

    private void Start()
    {
        Debug.Log(stringTest);

        //testListInt.Add(1);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time);
        float y = Mathf.Sin(Time.time);

        movingCube.transform.SetPositionAndRotation(new Vector3(x, y, 0), Quaternion.Euler(x * 360.0f, 0.0f, y * 360.0f));

        movingLight.intensity = baseIntensity * Mathf.Abs(x);
    }
}
