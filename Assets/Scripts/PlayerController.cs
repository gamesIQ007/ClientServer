using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;
    public PlayerStats PlayerStats => playerStats;

    [SerializeField] private ServerConnection connection;

    private void Start()
    {
        StartCoroutine(UpdateCoroutine());
    }

    private IEnumerator UpdateCoroutine()
    {
        UpdatePlayerStats();

        while (true)
        {
            yield return new WaitForSeconds(1);
            UpdatePlayerStats();
        }
    }

    public async void UpdatePlayerStats()
    {
        try
        {
            playerStats = await connection.RequestPlayerStatsAsync();
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}
