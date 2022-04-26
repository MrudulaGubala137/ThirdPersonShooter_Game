using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Range(0.5f, 1.5f)]
    float fireRate = 1f;
    [SerializeField]
    [Range(1f,10f)]
    float damageRate=1f;
    float timer;
    public Transform firePoint;
    public ParticleSystem particle;
    AudioSource audio;
    void Start()
    {
       audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if(timer >=fireRate)
        {
            if(Input.GetButton("Fire1"))
            {
                timer = 0f;
                ToFireGun();
            }
        }
        
    }
    private void ToFireGun()
    {
        Debug.DrawRay(firePoint.position, transform.forward* 100,Color.red,2f);
        Debug.Log("Drawn a ray");
        audio.Play();
        particle.Play();
        Ray ray = new Ray(firePoint.position, transform.forward);
        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo,100f))
        {
            //need to shoot the enemy
          var health=  hitInfo.collider.GetComponent<EnemyScript>();
            if (health != null)
            {
                health.DamageHealth(5);
            }
        }
    }
    
    
}
