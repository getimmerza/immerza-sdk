using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class TestBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject movingCube = null;

    [SerializeField]
    private Light movingLight = null;

    [SerializeField]
    private float baseIntensity;

    private async void Start()
    {
        using UnityWebRequest req = new UnityWebRequest("https://google.com", "GET");
        await req.SendWebRequest();
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
