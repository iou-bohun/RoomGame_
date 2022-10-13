using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowDetailText : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        GameObject canvasGm = GameObject.Find("Canvas");
        GameObject uiGm = canvasGm.transform.Find("DetailTextUI").gameObject;
        GameObject contentUI = uiGm.transform.Find("Content").gameObject;
        contentUI.GetComponent<TextMeshProUGUI>().text = "aaaaaaaaaaaaaa\n" +
            "bbbbbbbbbbbb\n" +
            "ccccccccccccccc\n";
        GameObject textUI = uiGm.transform.Find("Subject").gameObject;
        textUI.GetComponent<TextMeshProUGUI>().text = this.name;
        uiGm.SetActive(true);
    }
}
