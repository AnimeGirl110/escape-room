using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateScript : MonoBehaviour
{
    private string groundTag = "Ground";
    private string bulletTag = "Bullet";
    private bool isMoving = false;
    private Rigidbody rb;
    private float speed = 3f;
    private Vector3 trgt;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving) {
            Move(trgt);
        }
    }

    public void Move(Vector3 target) {
        trgt = target;
        if (Vector3.Magnitude(target - transform.position) < 0.05) {
            isMoving = false;
            transform.Translate(RoundThree(transform.position.x) - transform.position.x, 0, RoundThree(transform.position.z) - transform.position.z);
            // transform.position.z = RoundThree(transform.position.z);
            return;
        }
        rb.MovePosition(transform.position + (target - transform.position).normalized * Time.deltaTime * speed);
        isMoving = true;
    }

    // void OnCollisionStay(Collision collision) {
    //     if ((collision.gameObject.tag != groundTag) && (collision.gameObject.tag != bulletTag)) {
    //         isMoving = false;
    //     }
    // }

    float RoundThree(float num) {
        return Mathf.Round((num - 1.5f) / 3) * 3 + 1.5f;
    }
}
