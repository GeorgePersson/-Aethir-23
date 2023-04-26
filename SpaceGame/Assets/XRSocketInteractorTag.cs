using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class XRinteractorTag : XRSocketInteractor
{
    public string targetTag;

    public override bool CanSelect(IXRSelectInteractable interactable)
   {
        return base.CanSelect(interactable) && interactable.transform.CompareTag(targetTag);
    }
}
