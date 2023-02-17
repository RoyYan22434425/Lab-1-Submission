using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private float maxHealth = 100;
    private float playerHealth;
 
    void Start()
    {
        playerHealth = GameManager.Instance.PlayerHealth;
    }
 
    void Update()
    {
        
    }
}
