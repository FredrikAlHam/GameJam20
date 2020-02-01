using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableManager5 : MonoBehaviour
{
    public GameObject cable1, cable2, cable3, cable4, cable5;
    int randomColor;


    void Start()
    {
        cable1.GetComponent<Cable>().color = newRandomNumber();
        cable2.GetComponent<Cable>().color = newRandomNumber();
        cable3.GetComponent<Cable>().color = newRandomNumber();
        cable4.GetComponent<Cable>().color = newRandomNumber();
        cable5.GetComponent<Cable>().color = newRandomNumber();
    }

    void Update()
    {
        
    }

    int newRandomNumber()
    {
        return randomColor = Random.Range(1, 5);
    }
}
