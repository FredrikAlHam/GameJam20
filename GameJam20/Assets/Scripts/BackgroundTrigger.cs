using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackgroundTrigger : MonoBehaviour
{
    Image backgroundOff, backgroundOn, background1, background2, background3, background4, background5, background6, background7, backgroundBlack;
    int backgroundNumber = 0;
    bool hasStartedTimer, success;

    [SerializeField]
    AudioSource scream, footsteps, scissors, radio;
    
    void Start()
    {
        background1 = GameObject.Find("Background1").GetComponent<Image>();
        background2 = GameObject.Find("Background2").GetComponent<Image>();
        background3 = GameObject.Find("Background3").GetComponent<Image>();
        background4 = GameObject.Find("Background4").GetComponent<Image>();
        background5 = GameObject.Find("Background5").GetComponent<Image>();
        background6 = GameObject.Find("Background6").GetComponent<Image>();
        background7 = GameObject.Find("Background7").GetComponent<Image>();
        backgroundBlack = GameObject.Find("BackgroundBlack").GetComponent<Image>();
    }

    void Update()
    {
        if (Globals.radioStart)
        {
            radio.Play(0);
            Globals.radioStart = false;
        }
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
                radio.Stop();
                StartCoroutine(WaitTimer());
            }
            if (backgroundNumber == 4)
            {
                hasStartedTimer = true;
                backgroundOff = background5;
                backgroundOn = background6;
                StartCoroutine(WaitTimer());
            }
            if (backgroundNumber == 5)
            {
                hasStartedTimer = true;
                backgroundOff = background6;
                backgroundOn = background7;
                StartCoroutine(WaitTimer());
            }
            if (backgroundNumber == 6)
            {
                hasStartedTimer = true;
                background6.enabled = false;
                background7.enabled = true;
                scissors.Play(0);
                if (!success)
                {
                    StartCoroutine(DeathScene());
                }
                else if (success)
                {
                    StartCoroutine(SuccessScene());
                }
            }
        }
    }

    public IEnumerator WaitTimer()
    {
        yield return new WaitForSeconds(Globals.time);
        backgroundOff.enabled = false;
        backgroundBlack.enabled = true;
        footsteps.Play(0);
        yield return new WaitForSeconds(1.5f);
        footsteps.Stop();
        backgroundBlack.enabled = false;
        backgroundOn.enabled = true;
        backgroundBlack.enabled = false;
        backgroundNumber++;
        hasStartedTimer = false;
    }

    IEnumerator DeathScene()
    {
        backgroundBlack.enabled = true;
        scream.Play(0);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("DeathScene");
    }

    IEnumerator SuccessScene()
    {
        background7.enabled = false;
        background1.enabled = true;
        radio.Play(0);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("SuccessScene");
    }
}

public static class Globals
{
    public static int time;
    public static bool radioStart;
}
