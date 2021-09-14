using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private float jumpForce;

    private Rigidbody2D _rb;
    
    public PlayerJump(float jumpForce)
    {
        this.jumpForce = jumpForce;
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown("space")) _rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);     
    }
}
