using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int startingHealth;
    [SerializeField] int currentHealth;
    NavMeshAgent agent;
    public GameObject target;
    void Start()
    {
        currentHealth = startingHealth;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target!=null)
        {
            agent.SetDestination(target.transform.position);   
        }
        
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
