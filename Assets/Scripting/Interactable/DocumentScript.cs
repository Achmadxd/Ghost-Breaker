using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DocumentScript : MonoBehaviour, Iinteractable
{
    [SerializeField] DocumentContent content;
    public void Interact() {
        GameManager.instance.AddToList(content);
        Destroy(gameObject);
    }
}