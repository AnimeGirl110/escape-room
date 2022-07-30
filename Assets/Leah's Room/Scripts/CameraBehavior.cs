using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
  public class CameraBehavior : MonoBehaviour
  {
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
      target = GameObject.Find("PlayerObj").transform;
      //does this work?
    }

    private void LateUpdate()
    {
      transform.position = target.position;
      transform.rotation = target.rotation;
    }
  }
}
