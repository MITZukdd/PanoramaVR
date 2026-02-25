using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This component should be assigned to the navigation button in the scene
public class InteractionChecker : MonoBehaviour
{
    public GameObject[] buttonsInScene;

    [HideInInspector]
    public List<Button> buttons;
    
    private Button navigationButton;

    public bool Ordering = false;

    // Only relevant for button ordering
    private int currentButtonIndex = 0;

    // Start is called before the first frame update
    void Awake()
    {
        // Go trough assigned butrton gameobjects to collect their Button component in single list
        foreach (GameObject go in buttonsInScene){
            buttons.Add(go.GetComponentInChildren<Button>());
        }

        // This is relevant when Action Hotspots should appear sequentially ( eg washing hands after toilet, not other way around)
        if (Ordering)
        {
            for (int i=0; i<buttonsInScene.Length; i++) {
                buttonsInScene[i].SetActive(i==0);
            }
            for (int i=0; i<buttons.Count; i++) {
                buttons[i].onClick.AddListener(ActivateNextHotspot);
            }
        }
        

        // get the Button component from navigation Hotspot button
        navigationButton = GetComponent<Button>();
        // disable navigation as long as not all buttons were pressed
        navigationButton.gameObject.GetComponent<navigation>().enabled=false;
        navigationButton.onClick.AddListener(CheckInteraction);

    }

    public void ActivateNextHotspot(){
        currentButtonIndex++;
        try
        {
            buttonsInScene[currentButtonIndex].SetActive(true);
        } catch (Exception e) { return; }
        
    }

    public void CheckInteraction() {
        foreach (var button in buttons)
        {
            if (button == null) { 
                Debug.Log("Attention : Some Reference of an Interactable Action Hotspot was set to null in the Interaction manager");
                return;
            }
            //if (button.interactable) { Debug.Log("button " + button.name + " was still interactable"); }
            if (button.interactable) return;
        }

        // Invoke Navigation when all buttons were pressed once
        navigationButton.gameObject.GetComponent<navigation>().enabled = true;
        navigation navigation = gameObject.GetComponent<navigation>();
        navigation.Invoke("ChangeView",0);

        // Special Case after Einschleusen : show OP-Knigge when entering OP
        try { 
        if (navigationButton.gameObject.GetComponents<uinavigation>() != null) {
            navigationButton.gameObject.GetComponent<uinavigation>().enabled = true;
            uinavigation uinavigation = navigationButton.gameObject.GetComponent<uinavigation>();
            uinavigation.Invoke("ShowMenu", 0);

        }}
        catch (Exception e) { }
    } 
}
