using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fans : MonoBehaviour
{
    public int addFanPoint;
    private PlayerScript Player;
    public bool Satisfazer;

    public float grauSatisfacao = 1;
    private Animator _animator;

    private void Start()
    {
        TryGetComponent(out _animator);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PlayerScript>().IsPlayng)
            {
                collision.gameObject.GetComponent<FamousPoints>().Pontosganhar(addFanPoint);
            }
        }
    }
    
//verificardo
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Player = col.GetComponent<PlayerScript>();
            Satisfazer = true;
        }
    }

    void Update()
    {
        if (Satisfazer)
        {
            if (Player.IsPlayng)
            {
                if (_animator.GetCurrentAnimatorStateInfo(0).IsName("FansIddle"))
                {
                    _animator.Play("FanDancing");
                }
                grauSatisfacao -= Time.deltaTime;
                if (grauSatisfacao <= 0)
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (_animator.GetCurrentAnimatorStateInfo(0).IsName("FansDancing"))
                {
                    _animator.Play("FansIddle");
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Satisfazer = false;
        }
    }
}
