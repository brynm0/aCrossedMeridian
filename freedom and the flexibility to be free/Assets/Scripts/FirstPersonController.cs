using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : MonoBehaviour {

    public float movementSpeed = 5.0f;
    float rotPitch = 0;
    public float pitchRange = 85.0f;
    public float movementRoll = 5.0f;
    public float lookSpeed = 5.0f;
    float verticalVelocity = 0;
    public float jumpSpeed = 20.0f;

    CharacterController cc;
    // Use this for initialization
    void Start() {
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float horizontalSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        cc = GetComponent<CharacterController>();
        //Rotation
        if (Time.timeScale == 1.0F)
        {
            float rotYaw = lookSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(0, rotYaw, 0);
            rotPitch -= lookSpeed * Input.GetAxis("Mouse Y");
            rotPitch = Mathf.Clamp(rotPitch, -pitchRange, pitchRange);
            Camera.main.transform.localRotation = Quaternion.Euler(rotPitch, 0, 0);
            if (Input.GetAxis("Horizontal") > 0)
            {
                Camera.main.transform.localRotation = Quaternion.Euler(rotPitch, 0, -25 * horizontalSpeed * Time.deltaTime);
            }
                if (Input.GetAxis("Horizontal") < 0)
            {
            Camera.main.transform.localRotation = Quaternion.Euler(rotPitch, 0, 25 * - horizontalSpeed * Time.deltaTime);

            }
        }
        //Movement
        if (Input.GetButtonDown("Jump") && cc.isGrounded)
        {
            verticalVelocity = jumpSpeed;
        }
        //Velocity
        if (Input.GetButton("Jump") && (cc.isGrounded == false) && (verticalVelocity < -2))
        {
            verticalVelocity += (3 / 5) * Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            verticalVelocity += Physics.gravity.y * Time.deltaTime;

        }
        Vector3 speed = new Vector3(horizontalSpeed, verticalVelocity, forwardSpeed);

        speed = transform.rotation * speed;

        cc.Move(speed * Time.deltaTime);

     



    }
}
