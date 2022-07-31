using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casey_PlayerBehavior : MonoBehaviour
{
    private const float TRANSLATE_VEL = 5f;
    private const string MOUSE_X = "Mouse X";
    private const string MOUSE_Y = "Mouse Y";
    private const string VERTICAL = "Vertical";
    private const string HORIZONTAL = "Horizontal";

    private Vector2 rotation = Vector2.zero;
    public GameObject mount;
    public GameObject prefab;
    private float bulletLife = 0.05f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            (
                Vector3.forward * Input.GetAxis(VERTICAL) + 
                Vector3.right * Input.GetAxis(HORIZONTAL)
            ) * TRANSLATE_VEL * Time.deltaTime
        );
        rotation.x += Input.GetAxis(MOUSE_X);
        rotation.y += Input.GetAxis(MOUSE_Y);
        Quaternion xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        Quaternion yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left); 
        mount.transform.localRotation = yQuat;
        transform.localRotation = xQuat;
        if (Input.GetKeyDown("space")) {
            GameObject bullet = Instantiate(prefab);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            bullet.transform.position = transform.position;
            bullet.transform.Translate(transform.forward * 3);
            bullet.transform.localRotation = transform.localRotation;
            Destroy(bullet, bulletLife);
        }

    }
}