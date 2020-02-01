using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceEasterEgg : MonoBehaviour
{
    Image face;

    void Start()
    {
        face = GameObject.Find("Face").GetComponent<Image>();
    }

    public void ButtonFace()
    {
        StartCoroutine(waitFace());
    }

    IEnumerator waitFace()
    {
        face.enabled = true;
        yield return new WaitForSeconds(0.1f);
        face.enabled = false;
    }
}
