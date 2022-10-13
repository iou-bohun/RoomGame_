using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    private GameObject target;
    public GameObject letterInside;
   

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();

            //오브젝트 클릭시 이벤트 처리 
            if (target == this.gameObject)
            {
                gameObject.SetActive(false);
                letterInside.SetActive(true);
            }
        }
    }

    //클릭 오브젝트 탐지
    void CastRay()
    {
        target = null;
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero.normalized, 0f);

        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            target = hit.collider.gameObject;
        }
    }
}
