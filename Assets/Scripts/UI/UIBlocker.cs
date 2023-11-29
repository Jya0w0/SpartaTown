using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIBlocker : MonoBehaviour
{
    private static UIBlocker instance;
    private void Awake()
    {
        instance = this;

        HideUI();
    }
    
    public static void ShowUI()
    {
        instance.gameObject.SetActive(true);
    }

    public static void HideUI()
    {
        instance.gameObject.SetActive(false);
    }
}
