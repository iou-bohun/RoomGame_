using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int roomState;
    public bool room, collidor;
    [SerializeField]
    private Item chooseItem;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else if(_instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

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

    public Item SelectedItem
    {
        get { return chooseItem; }
        set
        {
            if (chooseItem == value)
                chooseItem = null;
            else
                chooseItem = value;
        }
    }
}
