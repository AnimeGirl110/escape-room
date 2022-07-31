using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior3 : MonoBehaviour
{
    public GameObject FakeWall3;

    private bool isColliding;

    void OnTriggerEnter(Collider other) {
        if (other.name == "Hero")
        {
            isColliding = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.name == "Hero")
        {
            isColliding = false;
        }
    }

    void Update(){
        if(isColliding)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(FakeWall3);
                Debug.Log("A passage reveals itself...");
            }
        }
    }

}
