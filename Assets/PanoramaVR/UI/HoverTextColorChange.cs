using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class HoverTextColorChange : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI text; // Reference to the TextMeshPro text component
    private Color normalColor = new Color(0, 0, 0, 0);
    //private Color hoverColor = new Color(240f/255f, 130f/255f, 98f/255f, 1); // light orange (as per the TUDD Corporate Design Med Colors
    private Color hoverColor = new Color(1,1,1, 1); // opaque whiite (better visibility?)

    void Start()
    {
        if (text == null)
            text = GetComponent<TextMeshProUGUI>(); // Automatically find the text if not assigned

        text.color = normalColor; // Set the initial color
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = hoverColor; // Change color when hovering
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = normalColor; // Revert color when no longer hovering
    }
}
