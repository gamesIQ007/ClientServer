using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerStats : MonoBehaviour
{
    [SerializeField] private PlayerController controller;

    [SerializeField] private Text goldText;
    [SerializeField] private Text levelText;

    private void Update()
    {
        goldText.text = controller.PlayerStats.Gold.ToString();
        levelText.text = controller.PlayerStats.Level.ToString();
    }
}
