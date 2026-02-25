using System;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine; 
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverimageShow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image img; 
    public TextMeshProUGUI text;
    private Color normalColor = new Color(0, 0, 0, 0);
    private Color hoverColor = new Color(1, 1, 1, 1);


    // Attention : this script expects a certain order of child Objects in the hierarchy:
    // First the Child with an Image Component, then a child with a TextMeshProUGUI component
    //After that any amount of children may follow

    void Start()
    {
        if (img == null)
            img = transform.GetChild(0).gameObject.GetComponent<Image>();
        img.enabled = false;

        if (text == null)
        {
            try
            {
                text = transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
                text.color = normalColor;
            } // Set the initial color}
            catch (Exception e)
            { text = null; }
                
        }  
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        img.enabled = true;
        if (text != null)
        {
            text.color = hoverColor; // Change color when hovering
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        img.enabled = false;
        if (text != null) { 
        text.color = normalColor; // Revert color when no longer hovering
        }
    }
}
