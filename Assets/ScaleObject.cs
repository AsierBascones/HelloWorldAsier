using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scale();
    }
    private void Scale()
    {
        if (Input.GetKeyDown(KeyCode.P)) transform.localScale += Time.deltaTime * Vector3.forward;
        if (Input.GetKeyDown(KeyCode.O)) transform.localScale += Time.deltaTime * Vector3.back;
        if (Input.GetKeyDown(KeyCode.L)) transform.localScale += Time.deltaTime * Vector3.right;
        if (Input.GetKeyDown(KeyCode.K)) transform.localScale += Time.deltaTime * Vector3.left;
        if (Input.GetKeyDown(KeyCode.M)) transform.localScale += Time.deltaTime * Vector3.down;
        if (Input.GetKeyDown(KeyCode.N)) transform.localScale += Time.deltaTime * Vector3.up;
    }

}
