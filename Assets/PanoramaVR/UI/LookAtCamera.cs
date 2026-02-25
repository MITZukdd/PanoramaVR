using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    private Transform targetCamera;
    private float referenceDistance = 2.5f;
    float basescale;


    void Start()
    {
        /*
        referenceDistance = GameObject.Find("---Views---").transform.localScale.x * referenceDistance;
        basescale = transform.localScale.x;
        // find the main camera if no camera was assigned */
        if (targetCamera == null)
        {
            targetCamera = Camera.main.transform;
        }
        
        FaceCamera();
        //AdjustScale();
        
    }
    
    private void Update()
    {
        FaceCamera();

        /*
        // Only adjust Scale when Camera is facing away
        Vector3 cameraToObject = transform.position - targetCamera.position;
        float dotProduct = Vector3.Dot(targetCamera.forward, cameraToObject.normalized);

        // If dot product is less than 0, object is behind the camera
        if (dotProduct < 0)
        {
        //AdjustScale();
        }
        */
    }
    

    void AdjustScale()
    { 
        var dist = Vector3.Distance(transform.position, targetCamera.position);
        transform.localScale = Vector3.one * basescale * dist / referenceDistance;
    }

    void FaceCamera()
    {
        // Make the canvas face the camera
        transform.LookAt(targetCamera);
        // Reverse rotation to avoid flipping
        transform.Rotate(0, 180, 0);
    }
}
