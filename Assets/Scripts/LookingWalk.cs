using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingWalk : MonoBehaviour
{
    public Transform vrCamera;
    public float toggleAngle = 30f;
    public float speed = 3f;
    public bool isMoveForward;

    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90)
        {
            isMoveForward = true;
        }
        else isMoveForward = false;

        if (isMoveForward)
        {
            Vector3 moveDirection = vrCamera.TransformDirection(Vector3.forward);
            controller.SimpleMove(moveDirection * speed);
        }
    }
}
