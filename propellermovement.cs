using UnityEngine;

public class propellermovement : MonoBehaviour
{
    public string objectToRotateName = "propeller";
    public float rotationSpeed = 300f;
    private bool isRotating = false;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            isRotating = true;
            RotateSelectedObject();
        }
        else
        {
            isRotating = false;
        }
    }

    void RotateSelectedObject()
    {
        GameObject objectToRotate = GameObject.Find(objectToRotateName);
        if (objectToRotate != null)
        {
            Quaternion localRotation = objectToRotate.transform.localRotation; // Current local orientation

            localRotation *= Quaternion.Euler(0f, 0f, rotationSpeed * Time.deltaTime); // New orieantation

            objectToRotate.transform.localRotation = localRotation; // Set new orientation
        }
    }
}
