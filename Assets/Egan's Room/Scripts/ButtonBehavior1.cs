using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior1 : MonoBehaviour
{
    public GameObject FakeWall1;

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
                Destroy(FakeWall1);
                Debug.Log("A passage reveals itself...");
            }
        }
    }

}
