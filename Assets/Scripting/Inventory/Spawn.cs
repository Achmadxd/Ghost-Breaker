using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    public void DropItem() {
        Vector3 dropPos = player.forward * 1f;
        Instantiate(item, dropPos, Quaternion.identity);
    }
}
