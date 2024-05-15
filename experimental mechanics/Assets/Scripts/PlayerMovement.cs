using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 40f;
    private float _horizontalInput;
    private float _verticalInput;

    private Rigidbody2D _rigidbody2d;
    
    
    private void Start(){
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("update working");
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        Debug.Log("player is moving");
        _verticalInput = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Firing");
            var weapon = GetComponentInChildren<UseWeapon>();
            if (weapon)
            {
                Debug.Log("Fored");
                weapon.Shoot();
            }
        }

    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // Apply movement
        _rigidbody2d.AddForce(new Vector3(_horizontalInput * moveSpeed, _verticalInput * moveSpeed, 0f));
        //transform.position += new Vector3(_horizontalInput * (moveSpeed*Time.deltaTime), _verticalInput * (moveSpeed*Time.deltaTime), 0f);
    }

    public void PossessPawn(GameObject pawn)
    {
        var newPlayerMove = pawn.GetComponent<PlayerMovement>();
        newPlayerMove.enabled = true;
    }
}
