using UnityEngine;

public class ReferenceTest : MonoBehaviour
{
    public TestBehaviour testBehaviour;

    private void Start()
    {
        if (testBehaviour != null)
        {
            Debug.Log("Reference works!");
        }
    }
}
