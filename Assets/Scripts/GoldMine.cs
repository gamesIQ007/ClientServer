using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMine : MonoBehaviour
{
    [SerializeField] private PlayerController controller;

    private void OnMouseDown()
    {
        controller.AddStatsAsync();
    }
}
