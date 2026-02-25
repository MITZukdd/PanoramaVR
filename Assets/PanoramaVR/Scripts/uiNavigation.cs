using UnityEngine;
using UnityEngine.UI;

public class uinavigation : MonoBehaviour
{
    private ImageManager imageManager; // Reference to the ImageManager
    public string target; // name of the target UI
    private Button button;

    public void Start()
    {
        imageManager = FindObjectOfType<ImageManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(ShowMenu);
    }

    // Call this on button click
    public void ShowMenu()
    {
        imageManager.ShowUI(target);
    }
}
