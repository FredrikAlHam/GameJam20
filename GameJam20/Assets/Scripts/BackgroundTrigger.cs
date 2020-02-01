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
    GameObject particleNotes;

    [SerializeField]
    AudioSource scream, footsteps, scissors, radio, door, gravelFootsteps, shortCircuit;
    
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
        Globals.time = 3;
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
                StartCoroutine(WaitTimerOutside());
            }
            if (backgroundNumber == 1)
            {
                hasStartedTimer = true;
                backgroundOff = background2;
                backgroundOn = background3;
                StartCoroutine(WaitTimerOutside());
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
                particleNotes.SetActive(false);
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
                if (!Globals.hasWon)
                {
                    StartCoroutine(DeathScene());
                }
                else if (Globals.hasWon)
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
        if (backgroundNumber == 5)
        {
            scissors.Play(0);
        }
        shortCircuit.Play(0);
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

    public IEnumerator WaitTimerOutside()
    {
        yield return new WaitForSeconds(Globals.time);
        backgroundOff.enabled = false;
        backgroundBlack.enabled = true;
        if (backgroundNumber == 1)
        {
            door.Play(0);
        }
        shortCircuit.Play(0);
        backgroundBlack.enabled = true;
        gravelFootsteps.Play(0);
        yield return new WaitForSeconds(1.5f);
        gravelFootsteps.Stop();
        backgroundBlack.enabled = false;
        backgroundOn.enabled = true;
        backgroundBlack.enabled = false;
        backgroundNumber++;
        hasStartedTimer = false;
    }

    IEnumerator DeathScene()
    {
        scream.Play(0);
        background7.enabled = true;
        yield return new WaitForSeconds(1.5f);
        backgroundBlack.enabled = true;
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GameOverMenu");
    }

    IEnumerator SuccessScene()
    {
        background1.enabled = true;
        radio.Play(0);
        particleNotes.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("EndGameMenu");
    }
}

public static class Globals
{
    public static int time;
    public static bool radioStart, hasWon;
}
