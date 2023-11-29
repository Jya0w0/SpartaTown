using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDownTime : MonoBehaviour
{
    [SerializeField] Text time;
    void Update()
    {
        time.text = DateTime.Now.ToString("tt hh : mm");
    }
}
