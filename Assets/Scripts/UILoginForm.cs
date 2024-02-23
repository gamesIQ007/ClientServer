using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILoginForm : MonoBehaviour
{
    [SerializeField] private PlayerInfo playerInfo;
    [SerializeField] private PlayerController controller;

    [SerializeField] private InputField loginInput;
    [SerializeField] private InputField passwordInput;

    public void Login()
    {
        playerInfo.SetPlayerInfo(loginInput.text, passwordInput.text);

        controller.enabled = true;

        gameObject.SetActive(false);
    }
}
