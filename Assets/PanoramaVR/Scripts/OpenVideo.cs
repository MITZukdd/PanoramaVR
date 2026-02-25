using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class openVideo : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OpenVideo);
    }

    void OpenVideo()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=8DKB8cZfXZk");
    }
}
