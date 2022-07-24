using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    private const string HORIZONTAL_INPUT = "Horizontal";
    public const float ROTATE_SPEED = 50f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis(HORIZONTAL_INPUT) * ROTATE_SPEED * Time.deltaTime);
    }
}
