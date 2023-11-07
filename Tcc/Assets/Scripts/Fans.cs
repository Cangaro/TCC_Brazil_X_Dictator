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

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Esta colidindo");
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
                grauSatisfacao -= Time.deltaTime;
                if (grauSatisfacao <= 0)
                {
                    Destroy(gameObject);
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
