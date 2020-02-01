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
    int randomChar, konstigsiffra1, konstigsiffra2, konstigsiffra3, konstigsiffra4, konstigSiffra69, konstigSiffra420, konstigSiffra1337, konstigSiffra3;

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
        konstigsiffra1 = NewRandomNumber(0, 11);
        c1Txt.text = character[konstigsiffra1].ToString();
        cable1.GetComponent<ShapeCable>().cableOrigin = konstigsiffra1;
        konstigsiffra2 = NewRandomNumber(0, 11);
        c2Txt.text = character[konstigsiffra2].ToString();
        cable2.GetComponent<ShapeCable>().cableOrigin = konstigsiffra2;
        konstigsiffra3 = NewRandomNumber(0, 11);
        c3Txt.text = character[konstigsiffra3].ToString();
        cable3.GetComponent<ShapeCable>().cableOrigin = konstigsiffra3;
        konstigsiffra4 = NewRandomNumber(0, 11);
        c4Txt.text = character[konstigsiffra4].ToString();
        cable4.GetComponent<ShapeCable>().cableOrigin = konstigsiffra4;

        konstigSiffra69 = NewRandomNumber(0, 11);
        fucktxt1.text = character[konstigSiffra69].ToString();
        fuck1.GetComponent<ShittyScriptThatNobodyLikes>().value = konstigSiffra69;
        konstigSiffra1337 = NewRandomNumber(0, 11);
        fucktxt2.text = character[konstigSiffra1337].ToString();
        fuck2.GetComponent<ShittyScriptThatNobodyLikes>().value = konstigSiffra1337;
        konstigSiffra3 = NewRandomNumber(0, 11);
        fucktxt3.text = character[konstigSiffra3].ToString();
        fuck3.GetComponent<ShittyScriptThatNobodyLikes>().value = konstigSiffra3;
        konstigSiffra420 = NewRandomNumber(0, 11);
        fucktxt4.text = character[konstigSiffra420].ToString();
        fuck4.GetComponent<ShittyScriptThatNobodyLikes>().value = konstigSiffra420;
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
