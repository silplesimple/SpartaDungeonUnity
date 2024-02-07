using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="DefaultPlayerData",menuName ="Scriptable/Player/PlayerInfo",order =0)]
public class PlayerSO : ScriptableObject
{
    [Header("Player StatsInfo")]
    public string Name;
    public string Info;
    public float Level;
    public float Gold;
    public float Attack;
    public float Defence;
    public float Health;
    public float Critical;
}
