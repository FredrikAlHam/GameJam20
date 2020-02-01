using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampMenu : MonoBehaviour
{
    bool swag = true;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        if (swag)
        {
            swag = false;
            StartCoroutine(LampFlicker());
        }

    }
    IEnumerator LampFlicker()
    {
        yield return new WaitForSeconds(3);
        GetComponent<Image>().color = Color.blue;
        yield return new WaitForSeconds(0.1f);
        GetComponent<Image>().color = Color.white;
        yield return new WaitForSeconds(0.02f);
        GetComponent<Image>().color = Color.blue;
        yield return new WaitForSeconds(0.2f);
        GetComponent<Image>().color = Color.white;
        yield return new WaitForSeconds(3);
        swag = true;
    }
}

