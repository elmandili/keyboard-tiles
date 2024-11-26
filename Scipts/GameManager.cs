using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[SerializeField]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public PlayerData data;
    private void Awake()
    {
        Instance = this;
        
    }
   public PlayerData NewPlayer()
    {
        return data = new PlayerData();
    }
}
