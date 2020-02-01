using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeCabelManager : MonoBehaviour
{
    public GameObject cable1, cable2, cable3, cable4;
    Text c1Txt, c2Txt, c3Txt, c4Txt, desttxt1, desttxt2, desttxt3, desttxt4;
    [SerializeField]
    char[] character;
    [SerializeField]
    GameObject dest1, dest2, dest3, dest4;
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
        desttxt1 = dest1.GetComponentInChildren<Text>();
        desttxt2 = dest2.GetComponentInChildren<Text>();
        desttxt3 = dest3.GetComponentInChildren<Text>();
        desttxt4 = dest4.GetComponentInChildren<Text>();

        //Gör nått med kod tror jag
        GameObject[] cables = { cable1, cable2, cable3, cable4 };
        genDest();
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
        GameObject[] dests = { dest1, dest2, dest3, dest4 };
        void genDest()
        {
            rnd = NewRandomNumber(0, 11);
            desttxt1.text = character[rnd].ToString();
            dest1.GetComponent<DestValStore>().value = rnd;
            rnd = NewRandomNumber(0, 11);
            desttxt2.text = character[rnd].ToString();
            dest2.GetComponent<DestValStore>().value = rnd;
            rnd = NewRandomNumber(0, 11);
            desttxt3.text = character[rnd].ToString();
            dest3.GetComponent<DestValStore>().value = rnd;
            rnd = NewRandomNumber(0, 11);
            desttxt4.text = character[rnd].ToString();
            dest4.GetComponent<DestValStore>().value = rnd;
        }
        bool p()
        {
            int tCorrect = 0;
            foreach (GameObject c in cables)
            {
                foreach (GameObject f in dests)
                {
                    if (WireBoxLogic.CheckWire(c.GetComponent<ShapeCable>().cableOrigin, f.GetComponent<DestValStore>().value, c.GetComponent<ShapeCable>().color, 4))
                    {
                        //print(c.GetComponent<ShapeCable>().cableOrigin + " " + f.GetComponent<ShittyScriptThatNobodyLikes>().value + " " + c.GetComponent<ShapeCable>().color);
                        print(WireBoxLogic.CheckWire(c.GetComponent<ShapeCable>().cableOrigin, f.GetComponent<DestValStore>().value, c.GetComponent<ShapeCable>().color, 4));
                        tCorrect++;
                    }
                }
            }
            if (tCorrect >= 4) return true; else return false;
        }

        while (!p()) 
        {
            genDest();
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
