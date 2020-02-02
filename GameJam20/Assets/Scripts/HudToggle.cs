using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudToggle : MonoBehaviour
{
    public bool isToggleOn;
    bool hudIsUp;
    [SerializeField]
    GameObject hud, hudToggleOn, hudToggleOff;

    private void OnMouseDown()
    {
        hudIsUp = !hudIsUp;

        if (isToggleOn)
        {
            hudToggleOn.SetActive(false);
            hudToggleOff.SetActive(true);
            hud.SetActive(true);
        }

        else if (!isToggleOn)
        {
            hudToggleOff.SetActive(false);
            hudToggleOn.SetActive(true);
            hud.SetActive(false);
        }
    }

    IEnumerator SlideHud(GameObject Vector3 startPos, Vector3 endPos, float time)
    {
        if (fadeObj == null)
        {
            yield return null;
        }

        var waitForEndOfFrame = new WaitForEndOfFrame();
        float elapsedTime = 0;

        if (fadeObj != null)
        {
            fadeObj.color = startColor;
        }

        while (elapsedTime < time)
        {
            fadeObj.color = Color.Lerp(startColor, endColor, elapsedTime / time);

            elapsedTime += Time.deltaTime;
            yield return waitForEndOfFrame;
        }

        if (fadeObj != null)
        {
            fadeObj.color = endColor;
        }
    }
}
