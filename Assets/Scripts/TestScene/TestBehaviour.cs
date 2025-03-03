using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;


public class TestBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject movingCube = null;

    [SerializeField] 
    private Transform testPosition;

    [SerializeField]
    private Light movingLight = null;

    [SerializeField]
    private float baseIntensity;

    public string stringTest = "Hello";

    [SerializeField]
    private Color testColor;

    [SerializeField]
    private List<Color> testColorArray;

    [SerializeField]
    private AnimationType chosenAnimationType;

    [SerializeField]
    private InputActionAsset xrInputAsset;

    private InputAction activateValueAction;

    /*[SerializeField] private List<int> testListInt = new();

    [SerializeField] private List<string> testListString = new();
    [SerializeField] private string[] testArrayString;
    [SerializeField] private float[] testArrayPrimitive;
    [SerializeField] private List<Light> testListReferences = new();
    [SerializeField] private MeshRenderer[] testArrayReferences;*/

    [SerializeField] private List<string> testStringArray = new();

    [SerializeField] private List<Material> testAssetReferences = new();
    [SerializeField] private List<GameObject> testPrefabReferences = new();

    [SerializeField] private GameObject[] testGOReferences;

    [SerializeField] private GameObject testGOReference;

    [SerializeField] private Light[] testLightReferences;

    [SerializeField] private TestSO testSO;

    private void Start()
    {
        Debug.Log(stringTest);

        foreach (GameObject go in testGOReferences)
        {
            Instantiate(go);
        }

        Instantiate(testGOReference);

        if (!xrInputAsset.enabled)
        {
            xrInputAsset.Enable();
        }

        activateValueAction = xrInputAsset.FindActionMap("XRI Left Interaction").FindAction("Activate Value");
    }

    private void OnDisable()
    {
        xrInputAsset.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(Time.time);
        float y = Mathf.Sin(Time.time);

        movingCube.transform.SetPositionAndRotation(new Vector3(testPosition.position.x + x, testPosition.position.y + y, testPosition.position.z), Quaternion.Euler(x * 360.0f, 0.0f, y * 360.0f));

        movingLight.intensity = baseIntensity * Mathf.Abs(x);

        if (activateValueAction != null)
        {
            float currentGripValue = activateValueAction.ReadValue<float>();
            Debug.Log(currentGripValue);
        }
        else
        {
            Debug.LogWarning("Input Action is null!");
        }
    }

    public enum AnimationType
    {
        isSwimToSpin,
        isSwimToJump
    }
}
