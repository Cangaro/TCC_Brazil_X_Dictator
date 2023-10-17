using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fans : MonoBehaviour
{
    public int addFanPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
            Debug.Log("Esta entrando");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Esta saindo");
        }
    }
}
