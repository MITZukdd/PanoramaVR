using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/* Used for Action Hotspots, where no strict ordering is needed but some previous interaction constraints have to be met
 * Intended to add to Gameobject containing a Button Component 
 */
public class CheckClothing : MonoBehaviour
{
    public GameObject[] buttonsInScene;

    [HideInInspector]
    public List<Button> buttons;

    private Button ownButtonComponent;

    // Start is called before the first frame update
    void Awake()
    {
        ownButtonComponent = GetComponent<Button>();
        ownButtonComponent.interactable = false;


        // Add button components to own list
        foreach (GameObject go in buttonsInScene)
        {
            buttons.Add(go.GetComponentInChildren<Button>());
        }

        for (int i = 0; i < buttons.Count; i++)
        {
            Button btn = buttons[i];  // Capture the actual button, not the index
            btn.onClick.AddListener(() => RemoveFromButtonsList(btn));
        }
        ownButtonComponent.onClick.AddListener(ChangeColor);

    }

    public void RemoveFromButtonsList(Button button)
    {
        buttons.Remove(button);
        if (buttons.Count == 0) { ownButtonComponent.interactable = true; }
    }
    public void ChangeColor()
    {
        ColorBlock cb = ownButtonComponent.colors;
        cb.disabledColor = new Color(0.396f, 0.702f, 0.18f, 1);
        ownButtonComponent.colors = cb;
    }
}
