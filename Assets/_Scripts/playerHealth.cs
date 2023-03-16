using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    
    public int maxHealth = 100;
    public int currentHealth;
    public int CurrentHealth
    {
        get
        {
            return currentHealth;
        }
        set
        {
            currentHealth = value;
        }
    }

    // Start is called before the first frame update
    private void Awake()
    {
        currentHealth = maxHealth;
        StartCoroutine(HealthIncrease());
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

    IEnumerator HealthIncrease()
    {
        for(int x = 1; x < maxHealth; x++)
        {
            currentHealth = x;
            if (OnHealthChanged != null)
            {
                OnHealthChanged(maxHealth, currentHealth);
            }

            yield return new WaitForSeconds(0.01f);
            Debug.Log("HP: " + currentHealth + " / " + maxHealth);
        }
        Debug.Log("The current health is " + currentHealth);
        Debug.Log("End Coroutine");
    }

    public event System.Action<int, int> OnHealthChanged;


    // Update is called once per frame
    public void DamageTaking (int amount){
        currentHealth -= amount;
    }
}
