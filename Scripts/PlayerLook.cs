using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;

    public float xSense = 50f;
    public float ySense = 50f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        // calculate the rotation
        xRotation -= mouseY * ySense * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //apply to our camera to transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //rotate player to left and right
        transform.Rotate(Vector3.up * mouseX * xSense * Time.deltaTime);
    }
}
