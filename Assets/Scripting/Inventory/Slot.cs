using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] int number;

    private void Start()
    {
        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if(transform.childCount <= 0){
            inventory.isFull[number] = false;
        }        
    }

    public void DropItem() {
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().DropItem();
            Destroy(child.gameObject);
        }
    }
}
