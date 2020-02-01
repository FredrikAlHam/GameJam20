using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    bool cableGrabbed;
    public int cableDestination, cableOrigin, color;
    SpriteRenderer sprite;
    Collider2D cableCollider;
    LineRenderer cableLine;
    Color red, blue, green;

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
            sprite.color = Color.red;
        }

        else if (color == 2)
        {
            sprite.color = Color.blue;
        }

        else if (color == 3)
        {
            sprite.color = Color.green;
        }

        else if (color == 4)
        {
            sprite.color = Color.white;
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
        CheckCorrectPlacement();
    }

    #region Methods

    void CheckCorrectPlacement()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (!cableGrabbed)
        {
            transform.position = col.transform.position;
        }
    }

    #endregion
}
