using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsEnemys : MonoBehaviour
{
    public AudioSource Batendo;

    public AudioSource Jumping;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Bateu()
    {
        Batendo.Play();
    }
}
