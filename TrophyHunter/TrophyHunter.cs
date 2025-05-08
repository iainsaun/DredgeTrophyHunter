using Galaxy.Api;
using UnityEngine;
using Winch.Config;

namespace TrophyHunter;

internal class TrophyHunter : MonoBehaviour
{
    GameConfigData gameConfigData;
    
    ModConfig Config => ModConfig.GetConfig();

    private void Start()
    {
        gameConfigData = GameManager.Instance.GameConfigData;
    }

    private void Update()
    {
        NotchSettings();   
    }

    private void NotchSettings()
    {
        gameConfigData.trophyNotchSpawnChance = Config.GetProperty<float>("notchchance") / 100;
        gameConfigData.baitedTrophyNotchSpawnChance= Config.GetProperty<float>("baitnotchchance") / 100;
        gameConfigData.fishToCatchBetweenTrophyNotches = Config.GetProperty<int>("catchnum");
    }
}
