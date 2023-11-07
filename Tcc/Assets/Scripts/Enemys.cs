using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    public float speed;
    public float WalkTime;

    private float Timer;
    private bool WalkRight;
    private Animator _animator;

    private Rigidbody2D rig;

    public int roubodepontos;
    public bool PARAR;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PARAR)
        {
            rig.velocity = Vector2.zero;
            return;
        }
        
        Timer += Time.deltaTime;

        if (Timer >= WalkTime)
        {
            WalkRight = !WalkRight; 
            Timer = 0f;
        }
        if (WalkRight)
        {
            transform.eulerAngles = new Vector2(0, 0);
            rig.velocity = Vector2.right * speed;
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 180);
            rig.velocity = Vector2.left * speed;
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    //QUANDO ESTIVER PERTO DO JOGADOR ELE fazer animação de bater para dar dano.
        if(collision.gameObject.CompareTag("Player"))
        {
            _animator.Play("MilicoBatendoCan");
            collision.gameObject.GetComponent<FamousPoints>().Pontosperder(roubodepontos);
            PARAR = true;
        }
    }
}
