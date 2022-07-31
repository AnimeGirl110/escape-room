using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isActivated = false;
    private string crateTag = "Crate";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == crateTag) {
            isActivated = true;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.tag == crateTag) {
            isActivated = false;
        }
    }
}
