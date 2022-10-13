using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterContent : MonoBehaviour
{
    private GameObject target;
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
            //������Ʈ Ŭ���� �̺�Ʈ ó�� 
            if (target == this.gameObject)
            {
                gameObject.SetActive(false);
            }
        }
    }

    //Ŭ�� ������Ʈ Ž��
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
