using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ButtonFeedback : MonoBehaviour, IPointerEnterHandler
{
    public XRRayInteractor interactor;
    private Button button;
    private float _cooldown = 0.3f;
    private float _lastHoverTime;
    private AudioSource _audioSource;
    public AudioClip hoverSound;
    public AudioClip selectSound;

    public float hoverAmplitude;
    public float selectAmplitude;
    public float hoverDuration;
    public float selectDuration;

    public void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(TriggerSelect);
        _audioSource = GetComponent<AudioSource>();
        if (_audioSource == null )
        {
            _audioSource = button.AddComponent<AudioSource>();
        }
        Destroy(button.GetComponent<EventTrigger>());
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        if (Time.time - _lastHoverTime < _cooldown) return;
        _lastHoverTime = Time.time;
        interactor.SendHapticImpulse(hoverAmplitude, hoverDuration);
        if (hoverSound != null && _audioSource != null)
        {
            _audioSource.PlayOneShot(hoverSound);
        }
    }

    public void TriggerSelect() {
        if (selectSound != null && _audioSource != null)
        {
            _audioSource.PlayOneShot(selectSound);
        }
        interactor.SendHapticImpulse(selectAmplitude, selectDuration);
    }
    private void OnDestroy()
    {
        if (button != null)
            button.onClick.RemoveListener(TriggerSelect);
    }
}
