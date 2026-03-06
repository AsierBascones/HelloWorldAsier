using Unity.VisualScripting;
using UnityEngine;

public class ColorTheWorld : MonoBehaviour
{
    public Color theColor;
    Object[] gameObjects;
    [SerializeField] private bool findByTag;
    [SerializeField] private string choosenTag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (findByTag)
        {
            if (choosenTag.Equals("blue"))
            {
                theColor = Color.blue;
            }
            else
            {
                theColor = Color.red;
            }
            gameObjects = GameObject.FindGameObjectsWithTag(choosenTag);
        }
        else
        {
            gameObjects = FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var gameObject in gameObjects)
        {
            if (gameObject.GetComponent<MeshRenderer>())
            {
                gameObject.GetComponent<MeshRenderer>().material.color = theColor;
            }
        }
    }
}
