using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int roomState;
    public bool room, collidor;

    public void RoomCheck()
    {
        if(roomState == 1)
        {
            collidor = true;
            room = false;
        }
        if(roomState == 2)
        {
            collidor = false;
            room = true;
        }
    }

}
