using System.Collections.Generic;
using UnityEngine;

public class BoxOpen : MonoBehaviour
{
    List<GameObject> screws = new List<GameObject>();
    // Update is called once per frame
    void Update()
    {
        screws.Clear();
        foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
        {
            if (transform.gameObject.name.Contains("Screw")) screws.Add(transform.gameObject);
        }
        if (screws.Count <= 0) Destroy(gameObject);
    }
}
