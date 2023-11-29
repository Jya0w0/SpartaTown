using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputID : MonoBehaviour
{
    public TMP_InputField inputID;
    public Button enterBtn;
    public TextMeshProUGUI playerID;
    public VisitortList visitortList;

    private string _playerID;

    void Start()
    {
        inputID.onEndEdit.AddListener(InputPlayerID);
        enterBtn.onClick.AddListener(EnterBtn);
    }

    private void InputPlayerID(string id)
    {
        _playerID = id;
    }

    public void EnterBtn()
    {
        playerID.text = _playerID;
        visitortList.PlayerID(_playerID);
        gameObject.SetActive(false);
    }
}
