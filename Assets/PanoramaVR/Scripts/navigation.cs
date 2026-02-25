using UnityEngine;
using UnityEngine.UI;

public class navigation : MonoBehaviour
{
    private ViewManager viewManager; // Reference to the SphereManager
    public string target; // name of the target sphere
    private Button button;

    public void Start()
    {
        viewManager = FindObjectOfType<ViewManager>();
        button =  GetComponent<Button>();
        button.onClick.AddListener(ChangeView);
    }

    // Call this on button click
    public void ChangeView()
    {
        viewManager.ShowSphere(target);
    }
}
