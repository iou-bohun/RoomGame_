using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    // Update is called once per frame
    public GameObject DoorL;
    public GameObject DoorR;
    public String DoorKey;

    [SerializeField]
    private bool isDoorOpen = false;

    void OnMouseUpAsButton()
    {
        IsDoorOpen();
        if (isDoorOpen)
        {
            DoorL.SetActive(true);
            DoorR.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else {
            Debug.Log("문이 잠겨있다.");
        }
    }

    private void IsDoorOpen()
    {
        if (!isDoorOpen)
        {
            String itemName = GameManager.Instance.SelectedItem?.itemName;
            if (DoorKey == itemName)
            {
                isDoorOpen = true;
            }
            else
            {
                return;
            }
        }
    }
}
