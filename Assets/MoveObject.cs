using UnityEngine;
using UnityEngine.UIElements;

public class MoveObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        Vector3 direction = Vector3.zero;
        float speed = 5f;

        if (Input.GetKey(KeyCode.W)) direction += Vector3.right;    // X = 2
        if (Input.GetKey(KeyCode.S)) direction += Vector3.left;     // X = -2
        if (Input.GetKey(KeyCode.A)) direction += Vector3.forward;  // Z = 2
        if (Input.GetKey(KeyCode.D)) direction += Vector3.back;     // Z = -2
        if (Input.GetKey(KeyCode.LeftShift)) direction += Vector3.up; // Y = 2
        if (Input.GetKey(KeyCode.LeftControl)) direction += Vector3.down; // Y = -2

        transform.position += direction.normalized * speed * Time.deltaTime;
    }
}
