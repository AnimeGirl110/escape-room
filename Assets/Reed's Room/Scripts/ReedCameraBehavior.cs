using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reed
{
  public class ReedCameraBehavior : MonoBehaviour
  {
    private Transform target;
    private Vector3 cameraOffset = new Vector3(0f, 1.5f, 0f);

    void Start()
    {
      target = GameObject.Find("PlayerObj").transform;
    }

    private void LateUpdate()
    {
      transform.position = target.position + cameraOffset;
      transform.rotation = target.rotation;
    }
  }
}
