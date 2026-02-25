using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.UI;
using Unity.VisualScripting;

public class HapticsManager : MonoBehaviour
{
    [SerializeField] public XRRayInteractor rayInteractor; // Reference to your interactor
    public AudioClip hover;
    public AudioClip select;
    public float hoverAmplitude;
    public float selectAmplitude;
    public float hoverDuration;
    public float selectDuration;

    private void Start()
    {
        if (rayInteractor == null)
        {
            rayInteractor = GetComponent<XRRayInteractor>();
            if (rayInteractor == null)
            {
                Debug.LogError("No XRRayInteractor found!");
                return;
            }
        }

        SetupAllInteractableHaptics();
    }

    private void SetupAllInteractableHaptics()
    {
        foreach (Button button in FindObjectsOfType<Button>(true)) {

            var trigger = button.AddComponent<ButtonFeedback>();
            trigger.hoverAmplitude = hoverAmplitude;
            trigger.selectAmplitude = selectAmplitude;
            trigger.hoverDuration = hoverDuration;
            trigger.selectDuration = selectDuration;
            trigger.interactor = rayInteractor;
            trigger.hoverSound = hover;
            trigger.selectSound = select;
        }
    }

    // Add this temporary method to test direct haptics
    private void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rayInteractor.SendHapticImpulse(0.7f, 0.5f);
        }
    }
}