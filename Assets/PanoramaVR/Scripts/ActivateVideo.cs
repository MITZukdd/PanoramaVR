using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateVideo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var VideoPlayer = transform.GetChild(0).GetChild(3).gameObject;
        VideoPlayer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
