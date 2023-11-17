 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Clarinete : MonoBehaviour
{
    private SpriteRenderer sr;
    private BoxCollider2D Bc;
    public int addFanPoint;
    

    public GameObject Collected;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        Bc = GetComponent<BoxCollider2D>();
    }

    //depois mudar para quando interagir ele ser destruido, e n�o apenas quando encostar.
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")

        {
           collider.gameObject.GetComponent<FamousPoints>().Pontosganhar(addFanPoint);
            sr.enabled = false;
            Bc.enabled = false;
            Collected.SetActive(true);
         
            Destroy(gameObject, 0.2f);
        }
    }
    
    
    
}
