using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMove : MonoBehaviour
{
    bool clickCheck;
    public GameObject room;
    public Camera camera;
    ButtonAction buttonAction;
    public GameObject gameManager;
    

    private void Update()
     {
            RoomMove();
      }

    public void RoomMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
            if (hit.collider != null )
            {
                if (clickCheck)
                    return;
                clickCheck = true;
                Vector3 cameraPos = room.transform.position;
                camera.transform.position = new Vector3(cameraPos.x, cameraPos.y, -10);
                GameManager game = gameManager.GetComponent<GameManager>();
                game.roomState = 1;
                Invoke("ClickCheck", 0.1f);
            }
        }
    }
    public void ClickCheck()
    {
        clickCheck = false;
    }
}

