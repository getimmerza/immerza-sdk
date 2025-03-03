using UnityEngine;

public class AnotherScript : MonoBehaviour
{
    public GameObject test;
    public string testString;

    void Update()
    {
        if (test == null)
        {
            Debug.LogWarning(gameObject.name + " : REFERENCE NOT SET : " + testString);
        }
        else
        {
            Debug.Log(gameObject.name + " : REFERENCE IS SET : " + testString);
        }
    }
}
