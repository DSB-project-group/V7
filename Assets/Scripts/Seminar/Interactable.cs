using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool useEvent;

    public void BaseInteract()
    {
        if (useEvent)
        {
            GetComponent<event_interact>().OnInteract.Invoke();
        }
        Interact();
    }
    protected virtual void Interact()
    {

    }
}
