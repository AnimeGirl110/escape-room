using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leah {
    public class PlayerBehavior : MonoBehaviour
    {
        private const float TRANSLATE_VEL = 2.5f;
        private const string MOUSE_X = "Mouse X";
        private const string MOUSE_Y = "Mouse Y";
        private const string VERTICAL = "Vertical";
        private const string HORIZONTAL = "Horizontal";

        private Vector2 rotation = Vector2.zero;

        // Start is called before the first frame update
        void Start()
        {
            Cursor.visible = false;
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(
                (
                    Vector3.forward * Input.GetAxis(VERTICAL) + 
                    Vector3.right * Input.GetAxis(HORIZONTAL) //+
                    // Vector3.up * (
                        // (Input.GetKey(KeyCode.E) ? 1 : 0) +
                        // (Input.GetKey(KeyCode.Q) ? -1 : 0)
                //    )
                ) * TRANSLATE_VEL * Time.deltaTime
            );
            if (!Input.GetMouseButton(0)) {
                return;
            }
            rotation.x += Input.GetAxis(MOUSE_X);
            rotation.y += Input.GetAxis(MOUSE_Y);
            Quaternion xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
            Quaternion yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left); 
            transform.localRotation = xQuat * yQuat;

        }
    }
}
