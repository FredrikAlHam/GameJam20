using UnityEngine;

public class BoxScrew : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private float totalRotation = 0;
    [SerializeField]
    private float scrollSensativity;
    [SerializeField]
    private float totalRotationRequired;
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
