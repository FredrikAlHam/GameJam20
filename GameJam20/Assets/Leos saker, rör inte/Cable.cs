using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    bool cableGrabbed;
    public bool isCorrect;
    public int cableDestination, cableOrigin, color, cableNumber;
    SpriteRenderer sprite;
    Collider2D cableCollider;
    LineRenderer cableLine;
    Color red, blue, green;
    string colorString;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        cableCollider = GetComponent<Collider2D>();
        cableLine = GetComponent<LineRenderer>();
        cableLine.SetPosition(0, transform.position);
        cableLine.SetPosition(1, transform.position);
    }

    void FixedUpdate()
    {
        cableLine.SetPosition(1, transform.position);

        #region Color shit

        if (color == 1)
        {
            colorString = "red";
            cableLine.SetColors(Color.red, Color.red);
        }

        else if (color == 2)
        {
            colorString = "blue";
            cableLine.SetColors(Color.blue, Color.blue);
        }

        else if (color == 3)
        {
            colorString = "green";
            cableLine.SetColors(Color.green, Color.green);
        }

        else if (color == 4)
        {
            colorString = "white";
            cableLine.SetColors(Color.white, Color.white);
        }

        #endregion

        if (cableGrabbed)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        }
    }

    void OnMouseDrag()
    {
        cableGrabbed = true;
    }

    void OnMouseUp()
    {
        cableGrabbed = false;
        isCorrect = false;
    }

    #region Methods

    void CheckCorrectPlacement()
    {
        if (WireBoxLogic.CheckWire(cableOrigin, cableDestination, colorString, cableNumber))
        {
            isCorrect = true;
            print("Correcto");
        }

        else
        {
            isCorrect = false;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (!cableGrabbed)
        {
            transform.position = col.transform.position;

            for (int i = 1; i <= 5; i++)
            {
                if (col.gameObject.tag == "Slot" + i.ToString())
                {
                    cableDestination = i;
                    CheckCorrectPlacement();
                    print(i);
                }
            }
        }
    }

    #endregion
}
