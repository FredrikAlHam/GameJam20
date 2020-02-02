using UnityEngine;

public class BoxScrew : MonoBehaviour
{
    [SerializeField]
    AudioSource screwdriver;

    float currentRotation, previousRotation, travel;

    [SerializeField]
    private float rotationSpeed = 5;
    [SerializeField]
    private float totalRotation = 0;
    [SerializeField]
    private float scrollSensativity = 10;
    [SerializeField]
    private float totalRotationRequired = 500;

    private void OnMouseOver()
    {
        if (totalRotation >= 0 && Input.GetAxis("Mouse ScrollWheel") >= 0)
        {
            transform.Rotate(0, 0, Input.GetAxis("Mouse ScrollWheel") * scrollSensativity);
            totalRotation += Input.GetAxis("Mouse ScrollWheel") * scrollSensativity;
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (totalRotation >= 0) transform.Rotate(0, 0, rotationSpeed);
            totalRotation += rotationSpeed;
        }
        if (totalRotation > totalRotationRequired) Destroy(gameObject);
    }
}


/*
            currentRotation = transform.rotation.z;
            travel = currentRotation - previousRotation;
            if (currentRotation != previousRotation)
            {
                screwdriver.Play(0);
                previousRotation = currentRotation;
            }
            else
            {
                screwdriver.Stop();
            }
*/