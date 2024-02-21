using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;
    public PlayerStats PlayerStats => playerStats;

    [SerializeField] private RequestCollection requestCollection;

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
        playerStats = await requestCollection.UpdatePlayerStatsAsync(playerStats);
    }

    public async void UpgradeLevel()
    {
        playerStats = await requestCollection.UpgradeLevel(playerStats);
    }
}
