using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisitortList : MonoBehaviour
{
    [SerializeField] Text visitor;
    
    public void PlayerID(string id)
    {
        visitor.text = id;
    }
}
