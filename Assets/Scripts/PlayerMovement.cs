using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    CharacterController characterController;
    Animator animator;
    public float rotationSpeed;
    void Start()
    {
        characterController= GetComponent<CharacterController>();
        animator= GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(inputX, 0f, inputZ);
       // characterController.Move(movement * Time.deltaTime);

        animator.SetFloat("Speed", movement.magnitude);
        /* if (movement.magnitude > 0f)
         {
             Quaternion tempDirection = Quaternion.LookRotation(movement);
             transform.rotation = Quaternion.Slerp(tempDirection, transform.rotation, Time.deltaTime * rotationSpeed);
         }*/
        transform.Rotate(Vector3.up, inputX * rotationSpeed * Time.deltaTime);
        if(inputZ!=0f)
        {
            characterController.Move(transform.forward * Time.deltaTime*inputZ);
        }
    }
}
