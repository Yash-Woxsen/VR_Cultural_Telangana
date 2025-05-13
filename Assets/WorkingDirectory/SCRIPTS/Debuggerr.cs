using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Debuggerr : MonoBehaviour
{
    public XRSimpleInteractable interactable;
    public GameObject infocreen;
    void OnEnable()
    {
        interactable.hoverEntered.AddListener(ToShow);
        interactable.hoverExited.AddListener(ToHide);
    }
    void OnDisable()
    {
        interactable.hoverEntered.RemoveAllListeners();
    }
    void ToShow(HoverEnterEventArgs args)
    {
        infocreen.SetActive(true);
    }
    void ToHide(HoverExitEventArgs args)
    {
        infocreen.SetActive(false);
    }
}
