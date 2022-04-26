using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int startingHealth;
    [SerializeField] int currentHealth;
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamageHealth(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("currentHealth:"+currentHealth);
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        gameObject.SetActive(false);
    }
}
