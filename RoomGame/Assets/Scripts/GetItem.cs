using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public Item item;

    private void OnMouseUpAsButton()
    {
        getItem();
    }

    public void getItem()
    {
        Debug.Log(item.itemName);
        var inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        inventory.AddItem(item);
        Destroy(this.gameObject);
    }
}
