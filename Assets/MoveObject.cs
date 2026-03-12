using UnityEngine;
using UnityEngine.UIElements;

public class MoveObject : MonoBehaviour
{
    [SerializeField] float speed = 5f;
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

        if (Input.GetKey(KeyCode.W)) direction += Vector3.right;    // X = +
        if (Input.GetKey(KeyCode.S)) direction += Vector3.left;     // X = -
        if (Input.GetKey(KeyCode.A)) direction += Vector3.forward;  // Z = +
        if (Input.GetKey(KeyCode.D)) direction += Vector3.back;     // Z = -
        if (Input.GetKey(KeyCode.LeftShift)) direction += Vector3.up; // Y = +
        if (Input.GetKey(KeyCode.LeftControl)) direction += Vector3.down; // Y = -

        transform.position += direction.normalized * speed * Time.deltaTime;
    }
}
