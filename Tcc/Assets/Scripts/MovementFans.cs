using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFans : MonoBehaviour
{
    
    public float speed;
    public float WalkTime;

    private float Timer;
    private bool WalkRight;

    private Rigidbody2D rig;

    public int AddFansPoints;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<FamousPoints>().Pontosganhar(AddFansPoints);
            Destroy(gameObject);
        }
    }
}


