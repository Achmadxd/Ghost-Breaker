using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedScript : MonoBehaviour, Iinteractable
{
    [SerializeField] Animator TextBoxChoose;

    public void Interact() {
        TextBoxChoose.SetBool("UI", true);
        Debug.Log(gameObject.name);
    }

    public void NoOption() {
        TextBoxChoose.SetBool("UI", false);
    }

    public void YesOption() {
        Debug.Log("it's save now");
    }
}