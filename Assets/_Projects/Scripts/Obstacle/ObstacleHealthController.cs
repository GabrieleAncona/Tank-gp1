using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHealthController : MonoBehaviour
{
    int health; // Ciao, io sono rimasto fuori, a cosa servo?
    int currentHealth;

    public void Init(int _health)
    {
        currentHealth = _health;
    }

    public void LoseHealth(int _amount)
    {
        currentHealth -= _amount;
    }

    public void GainHealth(int _amount)
    {
        // A cosa servo? Le props possono recuperare vita?
    }
}
