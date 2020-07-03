using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Singleton/MasterGameManager")]
public class MasterManager : SingletenScriptableObject<MasterManager>
{
    [SerializeField]
    private  SpeedManager _speedManager;

    [SerializeField]
    private GameSettings _gameSettings;

    public static GameSettings GameSettings => Instance._gameSettings;
    public static SpeedManager SpeedManager => Instance._speedManager;

}
