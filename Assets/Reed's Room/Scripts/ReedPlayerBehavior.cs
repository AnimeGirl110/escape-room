using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reed
{
  public class ReedPlayerBehavior : MonoBehaviour
  {
    private const float TRANSLATE_VEL = 2.5f;
    private const string MOUSE_X = "Mouse X";
    private const string MOUSE_Y = "Mouse Y";
    private const string VERTICAL = "Vertical";
    private const string HORIZONTAL = "Horizontal";

    private Vector2 rotation = Vector2.zero;
    private Vector3 rayOffset = new Vector3(0, 0, 0);

    private float maxDistance = 3;
    private int count;
    public bool isShowingGui;
    public string guiText;
    public bool isCalling = false;
    public bool isUnlocking = false;
    public bool isDecoding = false;
    public string callNumber = "";
    public string unlockNumber = "";
    public string decodeNumber = "";

    public AudioSource audio;
    public AudioClip callMessage;
    public AudioClip unlock;
    public AudioClip locked;
    public AudioClip wrongNum;

    public AudioClip dial;
    private bool hasUnlocked = false;
    public Animation doorAnim;

    // Start is called before the first frame update
    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if (isCalling || isUnlocking || isDecoding) return;
      RaycastHit hit;
      Vector3 p1 = transform.position + rayOffset;
      isShowingGui = false;

      if (Physics.SphereCast(p1, 0.5f, transform.forward, out hit, maxDistance))
      {
        if (hit.collider.gameObject.CompareTag("Locker") && !hasUnlocked)
        {
          guiText = "Enter 6 digit code";
          isShowingGui = true;
        }
        if (hit.collider.gameObject.CompareTag("Phone"))
        {
          guiText = "Dial Phone";
          isShowingGui = true;
        }
        if (hit.collider.gameObject.CompareTag("Code"))
        {
          guiText = "Enter 4 digit code";
          isShowingGui = true;
        }
      }


    }

    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        if (isCalling || isUnlocking)
        {
          isCalling = false;
          isUnlocking = false;
          callNumber = "";
          return;
        }
        if (isShowingGui)
        {
          if (guiText == "Dial Phone")
          {
            isCalling = true;
            guiText = "Enter Phone #";
          }
          if (guiText == "Enter 6 digit code")
          {
            isUnlocking = true;
            guiText = "Enter Code #";
          }
          if (guiText == "Enter 4 digit code")
          {
            isDecoding = true;
            guiText = "Enter Code #";
          }
        }

      }
      if (Input.GetKeyDown(KeyCode.Alpha0))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "0";
          guiText = callNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "0";
          guiText = unlockNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "0";
          guiText = decodeNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha1))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "1";
          guiText = callNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "1";
          guiText = unlockNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "1";
          guiText = decodeNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha2))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "2";
          guiText = callNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "2";
          guiText = unlockNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "2";
          guiText = decodeNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha3))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "3";
          guiText = callNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "3";
          guiText = unlockNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "3";
          guiText = decodeNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha4))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "4";
          guiText = callNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "4";
          guiText = unlockNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "4";
          guiText = decodeNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha5))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "5";
          guiText = callNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "5";
          guiText = decodeNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "5";
          guiText = unlockNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha6))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "6";
          guiText = callNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "6";
          guiText = unlockNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "6";
          guiText = decodeNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha7))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "7";
          guiText = callNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "7";
          guiText = decodeNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "7";
          guiText = unlockNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha8))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "8";
          guiText = callNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "8";
          guiText = decodeNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "8";
          guiText = unlockNumber;
        }
      }
      if (Input.GetKeyDown(KeyCode.Alpha9))
      {
        if (isCalling)
        {
          audio.PlayOneShot(dial, 0.7f);
          callNumber += "9";
          guiText = callNumber;
        }
        else if (isDecoding)
        {
          audio.PlayOneShot(dial, 0.7f);
          decodeNumber += "9";
          guiText = decodeNumber;
        }
        else if (isUnlocking)
        {
          audio.PlayOneShot(dial, 0.7f);
          unlockNumber += "9";
          guiText = unlockNumber;
        }
      }

      if (callNumber.Length > 9)
      {
        if (callNumber == "7138021196")
        {
          audio.PlayOneShot(callMessage, 0.4f);
        }
        else
        {
          audio.PlayOneShot(wrongNum, 0.7f);
        }
        isCalling = false;
        callNumber = "";
        guiText = "";
      }
      if (unlockNumber.Length > 5)
      {
        if (unlockNumber == "513098")
        {
          audio.PlayOneShot(unlock, 0.7f);
          GameObject.Find("door").transform.Rotate(0f, -90f, 0f, Space.Self);
          hasUnlocked = true;
        }
        else
        {
          audio.PlayOneShot(locked, 0.7f);
        }
        isUnlocking = false;
        guiText = "";
        unlockNumber = "";
      }
      if (decodeNumber.Length > 3)
      {
        if (decodeNumber == "8942")
        {
          audio.PlayOneShot(unlock, 0.7f);
          // GameObject.Find("Door_Joint").transform.Rotate(0f, 90f, 0f, Space.Self);
          doorAnim.Play("DoorOpening");
          // COMPLETE HERE
        }
        else
        {
          audio.PlayOneShot(locked, 0.7f);
        }
        isDecoding = false;
        guiText = "";
        decodeNumber = "";
      }



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
      rotation.x += Input.GetAxis(MOUSE_X);
      rotation.y += Input.GetAxis(MOUSE_Y);
      Quaternion xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
      Quaternion yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);
      transform.localRotation = xQuat * yQuat;

    }
  }
}