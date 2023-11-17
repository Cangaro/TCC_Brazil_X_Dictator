    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float Speed;
    public AudioSource AudioTocar;
    private Animator anim;
    private Rigidbody2D rig;
    
    public float JumpForce;
    public bool IsJumping;
    public bool IsPlayng;

    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        AudioTocar = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Play();
        TocarMusica();
        if (IsPlayng) return;
        Move();
        Jump();
        
    }
    
    public void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        if (Input.GetAxis("Horizontal") > 0f)
        {
            anim.SetBool("Walk", true);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetAxis("Horizontal") < 0f)
        { 
        anim.SetBool("Walk", true);
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }

        if (Input.GetAxis("Horizontal") == 0f)
            anim.SetBool("Walk", false);
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && !IsJumping)
        {
            rig.AddForce(new Vector2 (0f, JumpForce), ForceMode2D.Impulse);
            anim.SetBool("Jump", true);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            IsJumping = false;
            anim.SetBool("Jump", false);
        }

        if(collision.gameObject.tag == "Buraco")
        {
            transform.position = new Vector2(-5.511f, -3.27f);
        }
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            IsJumping = true;
        }

    }

     public void Play()
     {
         if (Input.GetKey(KeyCode.M))
         {
             
             IsPlayng = true;
             anim.SetBool("MusicAnim", true);
             
         }
         
         if (Input.GetKeyUp(KeyCode.M))
         {
             IsPlayng = false;
             anim.SetBool("MusicAnim", false);
             
         }
     }

     public void TocarMusica()
     {
         if (Input.GetKeyDown(KeyCode.M))
         {
             AudioTocar.Play();
         }
         
         if (Input.GetKeyUp(KeyCode.M))
         {
             AudioTocar.Stop();
         }
     }
     
}

