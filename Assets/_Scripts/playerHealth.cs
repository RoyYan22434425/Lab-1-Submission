using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    
    public int maxHealth = 100;
    public int currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public virtual void RestoreHealth(int restore)
    {
        // currentHealth += restore;
        // Make sure to not have health above max health
        currentHealth = Mathf.Clamp(currentHealth + restore, 0, maxHealth);

        Debug.Log(currentHealth);

        if (OnHealthChanged != null)
        {
            OnHealthChanged(maxHealth, currentHealth);
        }
    }

    public event System.Action<int, int> OnHealthChanged;


    // Update is called once per frame
    public void DamageTaking (int amount){
        currentHealth -= amount;
    }
}
