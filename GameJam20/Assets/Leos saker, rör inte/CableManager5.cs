using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableManager5 : MonoBehaviour
{
    public GameObject cable1, cable2, cable3, cable4, cable5;
    bool boxDone;
    int randomSHIT;


    void Start()
    {
        cable1.GetComponent<Cable>().color = newRandomNumber();
        cable2.GetComponent<Cable>().color = newRandomNumber();
        cable3.GetComponent<Cable>().color = newRandomNumber();
        cable4.GetComponent<Cable>().color = newRandomNumber();
        cable5.GetComponent<Cable>().color = newRandomNumber();
    }

    void FixedUpdate()
    {
        if (cable1.GetComponent<Cable>().isCorrect && cable2.GetComponent<Cable>().isCorrect && cable3.GetComponent<Cable>().isCorrect && cable4.GetComponent<Cable>().isCorrect && cable4.GetComponent<Cable>().isCorrect && cable5.GetComponent<Cable>().isCorrect)
        {
            boxDone = true;
            print("Jättefint! Otroligt bra gjort");
        }
    }

    int newRandomNumber()
    {
        return randomSHIT = Random.Range(1, 5);
    }
}
