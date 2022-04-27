using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject asteroid;
    float time;
    PlayerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
       
            time = time + Time.deltaTime;
            if (time > 3f)
            {
                
                GameObject tempEnemy = (ObjectPoolScript.instance.GetObjectsFromPool("Enemy"));

                tempEnemy.transform.position = tempEnemy.transform.position+new Vector3(Random.Range(-8.0f, 8f), 1f, Random.Range(-4.0f, 4f));
                tempEnemy.SetActive(true);

                time = 0;
                
            }
            
        }


    }