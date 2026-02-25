using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class changeUponClick : MonoBehaviour
{
    private Button button;
    public TextMeshProUGUI icon;
    public TextMeshProUGUI newDescription;
    public TextMeshProUGUI oldDescription;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeIcon);
        if (icon == null){
            icon = GetComponentsInChildren<TextMeshProUGUI>().ToList().Find(x => x.name == "Icon");
        }
        if (oldDescription == null) {
            oldDescription = GetComponentsInChildren<TextMeshProUGUI>().ToList().Find(x => x.name == "Title");
        }
        if (newDescription == null) { 
            newDescription = GetComponentsInChildren<TextMeshProUGUI>(true).ToList().Find(x => x.name == "Description");
        }
    }
    private void ChangeIcon()
    {
        icon.fontSize = 170;
        var newIcon = Instantiate(icon.gameObject, icon.transform.parent);
        newIcon.transform.localPosition = Vector3.zero;
        Destroy(icon.gameObject);
        newIcon.GetComponent<TMP_Text>().SetText("\u2713");
        button.interactable = false;
        if (newDescription != null) { newDescription.gameObject.SetActive(true); }
        if (oldDescription != null) {  oldDescription.gameObject.SetActive(false); }       

    }
}
