using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcScript : MonoBehaviour, Iinteractable
{
    public void Interact() {
        Debug.Log(gameObject.name);
    }
}
