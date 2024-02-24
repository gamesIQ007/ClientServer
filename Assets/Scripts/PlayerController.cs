using System.Collections;
using System.Threading.Tasks;
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

    public async void AddStatsAsync()
    {
        if (enabled == false) return;

        playerStats.Gold += playerStats.Level;

        playerStats = await requestCollection.AddGold(playerStats);
    }
}
