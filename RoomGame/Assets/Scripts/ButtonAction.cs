using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    bool clickCheck;
    Button button;
    public GameObject[] backGround;
    public Camera camera;
    public int scene;
    public GameObject gameManager;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickRightButton);
    }

    public void OnClickRightButton()
    {
        GameManager game = gameManager.GetComponent<GameManager>();
        game.RoomCheck();
        if(game.collidor == true)
        {
            if (clickCheck)
                return;
            clickCheck = true;
            if (button.name == "TurnRightButton")
            {
                if (scene >= 3)
                {
                    scene = -1;
                }
                scene++;
                Vector3 pos = backGround[scene].transform.position;
                camera.transform.position = new Vector3(pos.x, pos.y, -10);
                Invoke("ClickCheck", 0.1f);
                Debug.Log("1");
            }
            else if (button.name == "TurnLeftButton")
            {
                scene--;
                if (scene < 0)
                {
                    scene = 3;
                }
                Vector3 pos = backGround[scene].transform.position;
                camera.transform.position = new Vector3(pos.x, pos.y, -10);
                Invoke("ClickCheck", 0.1f);
                Debug.Log("2");
            }
        }
    }
   
    public void ClickCheck()
    {
        clickCheck = false;
    }
}
