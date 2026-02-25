using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    private List<GameObject> spheres; // Array to hold all spheres
    public GameObject ViewsHolder;
    public GameObject start;

    private void Start()
    {
        spheres = new List<GameObject>();
        foreach (Transform child in ViewsHolder.transform)
        {
            spheres.Add(child.gameObject);
        }
        // Initalize View to show Master 
        ShowSphere(start.name);
    }

    // Show the target sphere by reference and hide all others
    public void ShowSphere(string targetSphere)
    {
        foreach (GameObject sphere in spheres)
        {
            sphere.SetActive(sphere.name == targetSphere); // Activate if the reference matches
        }
    }
}
