using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="LevelObj",menuName ="Levels")]
public class LevelTwo : ScriptableObject
{
    public int levelIndex;
    public int targetScore;
    public float timer;
    public float appleSpawnTime;
    public float bombSpawnTime;
    public float crystalSpawnTime;
    public float appleDestroyTime;
    public float bombDestroyTime;
    public float crystalDestroyTime;
    public Sprite levelImage;
}
