using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudToggle : MonoBehaviour
{
    bool hudIsUp;
    [SerializeField]
    GameObject hud;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        hudIsUp = !hudIsUp;

        if (hudIsUp)
        {
            ToggleThing(false);
        }

        else
        {
            ToggleThing(true);
        }
    }

    void ToggleThing(bool mhm)
    {
        hud.SetActive(mhm);
    }
}
