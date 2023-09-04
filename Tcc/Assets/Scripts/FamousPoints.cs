using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FamousPoints : MonoBehaviour
{
    public Slider QntPoints;

    public int FamousMaxPoints;
    public int FamousAtualPoints; 


    // Start is called before the first frame update
    void Start()
    {
        QntPoints.maxValue = FamousMaxPoints;
        QntPoints.value = FamousAtualPoints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pontosganhar(int pontosparaReceber)
    {
        FamousAtualPoints += pontosparaReceber;
        QntPoints.value = FamousAtualPoints;

        if(FamousAtualPoints >= 100)
        {
            Debug.Log("YOU WIN");
        }

    }
    public void Pontosperder(int roubodepontos)
    {
        FamousAtualPoints -= roubodepontos;
        QntPoints.value = FamousAtualPoints;

        if (FamousAtualPoints <= 0)
        {
            Debug.Log("Game Over");
        }

    }
}
