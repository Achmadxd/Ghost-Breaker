using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScript : MonoBehaviour, Iinteractable
{
    private Inventory inventory;
    public GameObject itemButton;

    private void Start()
    {
        inventory = GameObject.Find("Player").GetComponent<Inventory>();    
    }

    public void Interact() {
        for (int i = 0; i < 4; i++)
        {
            if(inventory.isFull[i] == false){
                inventory.isFull[i] = true;
                Instantiate(itemButton, inventory.slots[i].transform, false);
                Destroy(gameObject);
                break;
            }
        }
    }
}
