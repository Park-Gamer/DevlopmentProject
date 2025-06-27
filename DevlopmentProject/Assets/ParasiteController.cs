using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParasiteController : MonoBehaviour
{
    // Settings
    public float MoveSpeed = 5;
    public float SteerSpeed = 180;
    public float BodySpeed = 5;

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(0f, 0f, vertical);

        if (inputDirection.magnitude >= 0.1f)
        {
            // Move forward
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            // Steer
            float steerDirection = Input.GetAxis("Horizontal"); // Returns value -1, 0, or 1
            transform.Rotate(Vector3.up * steerDirection * SteerSpeed * Time.deltaTime);
        }
    }
}
