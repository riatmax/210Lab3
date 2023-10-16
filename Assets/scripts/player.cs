using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 1f;
    public CharacterController CC;
    public float Gravity = -9.8f;
    public float verticalSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

        float ForwardMovement = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float SideMovement = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        movement += (transform.forward * ForwardMovement) + (transform.right * SideMovement);

        if (CC.isGrounded)
        {
            verticalSpeed = 0f;
        }

        verticalSpeed += (Gravity * Time.deltaTime);
        movement += (transform.up * verticalSpeed * Time.deltaTime);

        CC.Move(movement);
    }
}