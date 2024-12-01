using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Health health;

    private void Update()
    {
        Debug.Log(health.currentHealth);

        if (health != null)
        {
            if (gameManager != null)
            {
                if (health.currentHealth <= 10)
                {
                    gameManager.GameOver();
                    Destroy(gameObject);
                }
            }
            else
            {
                Debug.Log("Base has no reference to GameManager");
            }

        }
        else
        {
            Debug.Log("Base has no reference to Health");
        }
    }
}
