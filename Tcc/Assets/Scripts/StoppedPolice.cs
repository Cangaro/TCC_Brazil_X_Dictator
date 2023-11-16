using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoppedPolice : MonoBehaviour
{
    private Animator _animator;

    private Rigidbody2D rig;

    public int roubodepontos;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _animator.Play("PolliceFire");
            collision.gameObject.GetComponent<FamousPoints>().Pontosperder(roubodepontos);
        }
    }
   }
