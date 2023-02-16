using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    
    public int health;
    public int maxHealth = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth; 
    }

    // Update is called once per frame
    public void DamageTaking (int amount){
        health -= amount;
    }
}
