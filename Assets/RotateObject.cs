using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
    private void Rotate()
    {   
        if (Input.GetKey(KeyCode.AltGr)) transform.rotation *= Quaternion.Euler(0, 1, 0);
        if (Input.GetKey(KeyCode.F2)) transform.rotation *= Quaternion.Euler(0, -1, 0);
        if (Input.GetKey(KeyCode.F3)) transform.rotation *= Quaternion.Euler(1, 0, 0);
        if (Input.GetKey(KeyCode.F4)) transform.rotation *= Quaternion.Euler(-1, 0, 0);
        if (Input.GetKey(KeyCode.F5)) transform.rotation *= Quaternion.Euler(0, 0, 1);
        if (Input.GetKey(KeyCode.F6)) transform.rotation *= Quaternion.Euler(0, 0, -1);
    }
}
