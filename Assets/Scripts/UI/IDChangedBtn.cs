using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDChangedBtn : MonoBehaviour
{
    public Button idBtn;
    public InputID inputIDUI;

    void Start()
    {
        idBtn.onClick.AddListener(IDBtn);
    }

    public void IDBtn()
    {
        inputIDUI.gameObject.SetActive(true);
    }
}
