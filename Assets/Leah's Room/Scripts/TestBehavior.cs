using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class TestBehavior : MonoBehaviour
    {
        void Start()
        {
            GameObject.Find("Door_Joint").GetComponent<Animation>().Play("DoorOpening");
            GameObject.Find("Door_Joint").GetComponent<AudioSource>().Play();
        }
    }
}
