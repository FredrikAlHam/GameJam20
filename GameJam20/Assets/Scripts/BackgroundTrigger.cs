using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTrigger : MonoBehaviour
{
    SpriteRenderer backgroundOff, backgroundOn, background1, background2, background3, background4, background5, background6, backgroundBlack;
    int backgroundNumber = 0;
    bool hasStartedTimer;
    
    void Start()
    {
        //CHANGE TO SPRITE RENDERER
        background1 = GameObject.Find("Background1").GetComponent<SpriteRenderer>();
        background2 = GameObject.Find("Background2").GetComponent<SpriteRenderer>();
        background3 = GameObject.Find("Background3").GetComponent<SpriteRenderer>();
        background4 = GameObject.Find("Background4").GetComponent<SpriteRenderer>();
        background5 = GameObject.Find("Background5").GetComponent<SpriteRenderer>();
        background6 = GameObject.Find("Background6").GetComponent<SpriteRenderer>();
        backgroundBlack = GameObject.Find("BackgroundBlack").GetComponent<SpriteRenderer>();
        Globals.time = 5;
    }

    void Update()
    {
        if (!hasStartedTimer)
        {
            if (backgroundNumber == 0)
            {
                hasStartedTimer = true;
                backgroundOff = background1;
                backgroundOn = background2;
                StartCoroutine(WaitTimer());
            }
            if (backgroundNumber == 1)
            {
                hasStartedTimer = true;
                backgroundOff = background2;
                backgroundOn = background3;
                StartCoroutine(WaitTimer());
            }
            if (backgroundNumber == 2)
            {
                hasStartedTimer = true;
                backgroundOff = background3;
                backgroundOn = background4;
                StartCoroutine(WaitTimer());
            }
            if (backgroundNumber == 3)
            {
                hasStartedTimer = true;
                backgroundOff = background4;
                backgroundOn = background5;
                StartCoroutine(WaitTimer());
            }
            if (backgroundNumber == 4)
            {
                hasStartedTimer = true;
                backgroundOff = background5;
                backgroundOn = background6;
                StartCoroutine(WaitTimer());
            }
        }
    }

    public IEnumerator WaitTimer()
    {
        yield return new WaitForSeconds(Globals.time);
        backgroundOff.enabled = false;
        StartCoroutine(BlackScreen());
        backgroundOn.enabled = true;
        backgroundBlack.enabled = false;
        backgroundNumber++;
        hasStartedTimer = false;
    }

    IEnumerator BlackScreen()
    {
        backgroundBlack.enabled = true;
        yield return new WaitForSeconds(2);
        backgroundBlack.enabled = false;
    }
}

public static class Globals
{
    public static int time;
}
