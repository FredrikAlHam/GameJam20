using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeCabelManager : MonoBehaviour
{
    public GameObject cable1, cable2, cable3, cable4;
    Text c1Txt, c2Txt, c3Txt, c4Txt, fucktxt1, fucktxt2, fucktxt3, fucktxt4;
    [SerializeField]
    char[] character;
    [SerializeField]
    GameObject fuck1, fuck2, fuck3, fuck4;
    bool boxDone;
    int randomChar, rnd;

    void Start()
    {
        cable1.GetComponent<ShapeCable>().color = NewRandomNumber(1, 5);
        cable2.GetComponent<ShapeCable>().color = NewRandomNumber(1, 5);
        cable3.GetComponent<ShapeCable>().color = NewRandomNumber(1, 5);
        cable4.GetComponent<ShapeCable>().color = NewRandomNumber(1, 5);

        c1Txt = cable1.GetComponentInChildren<Text>();
        c2Txt = cable2.GetComponentInChildren<Text>();
        c3Txt = cable3.GetComponentInChildren<Text>();
        c4Txt = cable4.GetComponentInChildren<Text>();
        fucktxt1 = fuck1.GetComponentInChildren<Text>();
        fucktxt2 = fuck2.GetComponentInChildren<Text>();
        fucktxt3 = fuck3.GetComponentInChildren<Text>();
        fucktxt4 = fuck4.GetComponentInChildren<Text>();

        //Gör nått med kod tror jag
        GameObject[] cables = { cable1, cable2, cable3, cable4 };
        genFuck();
        genCab();
        void genCab()
        {
            rnd = NewRandomNumber(0, 11);
            c1Txt.text = character[rnd].ToString();
            cable1.GetComponent<ShapeCable>().cableOrigin = rnd;
            rnd = NewRandomNumber(0, 11);
            c2Txt.text = character[rnd].ToString();
            cable2.GetComponent<ShapeCable>().cableOrigin = rnd;
            rnd = NewRandomNumber(0, 11);
            c3Txt.text = character[rnd].ToString();
            cable3.GetComponent<ShapeCable>().cableOrigin = rnd;
            rnd = NewRandomNumber(0, 11);
            c4Txt.text = character[rnd].ToString();
            cable4.GetComponent<ShapeCable>().cableOrigin = rnd;
        }
        GameObject[] fuck = { fuck1, fuck2, fuck3, fuck4 };
        void genFuck()
        {
            rnd = NewRandomNumber(0, 11);
            fucktxt1.text = character[rnd].ToString();
            fuck1.GetComponent<ShittyScriptThatNobodyLikes>().value = rnd;
            rnd = NewRandomNumber(0, 11);
            fucktxt2.text = character[rnd].ToString();
            fuck2.GetComponent<ShittyScriptThatNobodyLikes>().value = rnd;
            rnd = NewRandomNumber(0, 11);
            fucktxt3.text = character[rnd].ToString();
            fuck3.GetComponent<ShittyScriptThatNobodyLikes>().value = rnd;
            rnd = NewRandomNumber(0, 11);
            fucktxt4.text = character[rnd].ToString();
            fuck4.GetComponent<ShittyScriptThatNobodyLikes>().value = rnd;
        }
        bool p()
        {
            int tCorrect = 0;
            foreach (GameObject c in cables)
            {
                foreach (GameObject f in fuck)
                {
                    if (WireBoxLogic.CheckWire(c.GetComponent<ShapeCable>().cableOrigin, f.GetComponent<ShittyScriptThatNobodyLikes>().value, c.GetComponent<ShapeCable>().color, 4))
                    {
                        //print(c.GetComponent<ShapeCable>().cableOrigin + " " + f.GetComponent<ShittyScriptThatNobodyLikes>().value + " " + c.GetComponent<ShapeCable>().color);
                        print(WireBoxLogic.CheckWire(c.GetComponent<ShapeCable>().cableOrigin, f.GetComponent<ShittyScriptThatNobodyLikes>().value, c.GetComponent<ShapeCable>().color, 4));
                        tCorrect++;
                    }
                }
            }
            if (tCorrect >= 4) return true; else return false;
        }

        while (!p()) 
        {
            genFuck();
            genCab();
        }
        print("F");
    }

    void FixedUpdate()
    {
        if (cable1.GetComponent<ShapeCable>().isCorrect && cable2.GetComponent<ShapeCable>().isCorrect && cable3.GetComponent<ShapeCable>().isCorrect && cable4.GetComponent<ShapeCable>().isCorrect && cable4.GetComponent<ShapeCable>().isCorrect)
        {
            boxDone = true;
            print("Jättefint! Otroligt bra gjort");
        }
    }

    int NewRandomNumber(int min, int max)
    {
        return randomChar = Random.Range(min, max);
    }
}
