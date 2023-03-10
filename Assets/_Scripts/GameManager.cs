using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float PlayerHealth;
 
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            PlayerHealth = 100;
        }
        else
        {
            Destroy(this);
        }
    }
}
