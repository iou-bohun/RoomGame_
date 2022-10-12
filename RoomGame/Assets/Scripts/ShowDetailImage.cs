using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowDetailImage : MonoBehaviour
{
    public Sprite sprite;
    private void OnMouseUpAsButton()
    {
        GameObject canvasGm = GameObject.Find("Canvas");
        GameObject uiGm = canvasGm.transform.Find("DetailImageUI").gameObject;
        GameObject imageUI = uiGm.transform.Find("DetailImage").gameObject;
        imageUI.GetComponent<Image>().sprite = sprite;
        GameObject textUI = uiGm.transform.Find("Subject").gameObject;
        textUI.GetComponent<TextMeshProUGUI>().text = this.name;
        uiGm.SetActive(true);
    }
}
