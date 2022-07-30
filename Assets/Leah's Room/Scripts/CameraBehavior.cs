using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
  public class CameraBehavior : MonoBehaviour
  {
    private Transform target;

    void Start()
    {
      target = GameObject.Find("PlayerObj").transform;
    }

    private void LateUpdate()
    {
      transform.position = target.position;
      transform.rotation = target.rotation;
    }
  }
}
