using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class HoverTextShow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI text; // Reference to the TextMeshPro text component
    private Color normalColor = new Color(0, 0, 0, 0);
    private Color hoverColor = new Color(1, 1, 1, 1);

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
