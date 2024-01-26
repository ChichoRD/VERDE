using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int maxHealth = 10;
    int currentHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }

    public void Damaged(int damageTaken) 
    {
        currentHealth = currentHealth - damageTaken;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }    
}
