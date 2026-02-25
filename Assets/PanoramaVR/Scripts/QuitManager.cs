using UnityEngine;
using UnityEngine.XR;

public class QuitOnBButton : MonoBehaviour
{
    private InputDevice rightController;
    private bool hasRightController = false;

    void Start()
    {
        TryInitializeRightController();
    }

    void Update()
    {
        // Try to find right-hand controller if not yet found
        if (!hasRightController || !rightController.isValid)
            TryInitializeRightController();

        // Check if B button is pressed
        if (rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool bPressed) && bPressed)
        {
            Application.Quit();
        }
    }

    void TryInitializeRightController()
    {
        var inputDevices = new System.Collections.Generic.List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, inputDevices);

        if (inputDevices.Count > 0)
        {
            rightController = inputDevices[0];
            hasRightController = true;
            Debug.Log("Right-hand controller found: " + rightController.name);
        }
    }
}
