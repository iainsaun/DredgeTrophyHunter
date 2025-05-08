using Winch.Core;
using UnityEngine;
using Cinemachine;
using HarmonyLib;
using Winch.Util;
using System.Reflection;

namespace TrophyHunter;

public class Loader
{
    public static void Initialize()
    {
        // initialize here init
        WinchCore.Log.Debug("Initializing TrophyHunter");

        new Harmony("iainsaun.trophyhunter").PatchAll();

        //ApplicationEvents.Instance.OnGameLoaded += OnGameLoadInitialisation;
    }
}