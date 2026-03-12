using System.Runtime.CompilerServices;
using UnityEngine;

public class PositionTracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PositionLogTrace();
    }
    
    private void PositionLogTrace()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Vector3 posicion = transform.position;

            Debug.Log("Posición de " + gameObject.name + ": " + posicion);
        }
    }
}