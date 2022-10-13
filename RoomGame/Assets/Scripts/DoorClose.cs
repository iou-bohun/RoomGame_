using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{
    public GameObject DoorL;
    public GameObject DoorR;
    public GameObject DoorLock;
    void OnMouseUpAsButton()
    {
        DoorL.SetActive(false);
        DoorR.SetActive(false);
        DoorLock.SetActive(true);
    }
}
