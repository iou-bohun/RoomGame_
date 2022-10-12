using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public Item item;
    public Inventory inventory;

    public void getItem()
    {
        Debug.Log(item.itemName);
        inventory.AddItem(this.item);
        Destroy(GameObject.Find(this.item.itemName));
    }
}
