using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class ImageManager : MonoBehaviour
{
    private List<GameObject> uis; // Array to hold all different canvases
    public GameObject UICanvases;
    private VideoManager vm;
    public GameObject start;


    private void Start()
    {
        vm = GameObject.FindObjectOfType<VideoManager>();

        uis = new List<GameObject>();
        foreach (Transform child in UICanvases.transform)
        {
            uis.Add(child.gameObject);
        }


        // Initalize View to show only Einweisung 
        Initialize();
    }

    // Show the target sphere by reference and hide all others
    public void ShowUI(string target)
    {
        if (vm.videoUi.activeSelf)
        {
            vm.videoUi.SetActive(false);
            return;
        }
        foreach (GameObject ui in uis)
        {
            ui.SetActive(ui.name == target); // Activate if the reference matches
        }
    }

    void Initialize()
    {
        if (start == null) return;
        foreach (GameObject ui in uis)
        {
            if (ui == null) continue; // Skip unassigned elements, so no errors are thrown, in case i delete a ui, and forget to remove it from the list
            ui.SetActive(ui.name == start.name);
        }
    }
}

