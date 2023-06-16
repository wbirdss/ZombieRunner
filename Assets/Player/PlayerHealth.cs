using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    DeathHandler deathHandler;

    private void Start() {
        deathHandler = GetComponent<DeathHandler>();
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            if (deathHandler != null)
            {
                deathHandler.HandleDeath();
            }
            else
            {
                Debug.Log("No dealth handler for player");
            }
        }
    }
}
