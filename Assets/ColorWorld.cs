using Unity.VisualScripting;
using UnityEngine;

public class ColorWorld : MonoBehaviour
{
    public Color myColor = Color.white;
    public Object[] allTheGameObjects;
    public bool findByTag;
    public string choosenTag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (findByTag)
        {
            allTheGameObjects = GameObject.FindGameObjectsWithTag(choosenTag);
        }
        else
        {
            allTheGameObjects = GameObject.FindObjectsByType<MeshRenderer>(FindObjectsSortMode.None);
        }

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Object obj in allTheGameObjects)
        {
            // 1. Obtenemos el componente MeshRenderer sin importar qué guardamos en el array
            MeshRenderer mesh = null;

            if (obj is GameObject go)
                mesh = go.GetComponent<MeshRenderer>();
            else if (obj is MeshRenderer mr)
                mesh = mr;

            // 2. Si logramos encontrar un mesh, aplicamos la lógica de color
            if (mesh != null)
            {
                if (findByTag)
                {
                    if (mesh.CompareTag("Blue"))
                        mesh.material.color = Color.blue;
                    else if (mesh.CompareTag("Red"))
                        mesh.material.color = Color.red;
                }
                else
                {
                    mesh.material.color = myColor;
                }
            }
        }
    }
}
