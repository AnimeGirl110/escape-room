using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private GameObject player;
    private ManagerScript manager;
    private float crateSize = 3f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        manager = GameObject.Find("Manager").GetComponent<ManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        float diffX = player.transform.position.x - collision.gameObject.transform.position.x;
        float diffZ = player.transform.position.z - collision.gameObject.transform.position.z;
        if (diffZ > diffX) {
            if (diffX > 0) {
                if (player.transform.position.x > collision.gameObject.transform.position.x - crateSize && player.transform.position.x < collision.gameObject.transform.position.x + crateSize) {
                    manager.RequestMove(collision.gameObject, collision.gameObject.transform.position - collision.gameObject.transform.forward * crateSize);
                    Debug.Log(collision.gameObject.transform.position - collision.gameObject.transform.forward * crateSize);
                }
            } else {
                if (player.transform.position.z > collision.gameObject.transform.position.z - crateSize && player.transform.position.z < collision.gameObject.transform.position.z + crateSize) {
                    manager.RequestMove(collision.gameObject, collision.gameObject.transform.position + collision.gameObject.transform.right * crateSize);
                }
            }
        } else {
            if (diffZ > 0) {
                if (player.transform.position.z > collision.gameObject.transform.position.z - crateSize && player.transform.position.z < collision.gameObject.transform.position.z + crateSize) {
                    manager.RequestMove(collision.gameObject, collision.gameObject.transform.position - collision.gameObject.transform.right * crateSize);
                }
            } else {
                if (player.transform.position.x > collision.gameObject.transform.position.x - crateSize && player.transform.position.x < collision.gameObject.transform.position.x + crateSize) {
                    manager.RequestMove(collision.gameObject, collision.gameObject.transform.position + collision.gameObject.transform.forward * crateSize);
                }
            }
        }
    }
}
