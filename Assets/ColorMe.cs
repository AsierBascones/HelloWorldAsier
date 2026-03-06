using UnityEngine;

public class ColorMe : MonoBehaviour
{
    public Color myColor = Color.blue;
    [SerializeField] 
    private MeshRenderer myMeshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        myMeshRenderer.material.color = myColor;
    }
}
