using UnityEngine;

public class RotateMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0.0f, 20.0f * Time.deltaTime, 0.0f);
    }
}
