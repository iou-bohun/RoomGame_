using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject backGround;
    public Camera camera;
   
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Vector3 pos = backGround.transform.position;
            camera.transform.position = new Vector3(pos.x, pos.y, -10);
            Debug.Log(pos.x);
        }
    }
}
