using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Transform vrCamera;

    public float speed = 3f;

    [SerializeField]
    private bool isForward = false;
    [SerializeField]
    private bool isBackward = false;
    [Header("Components")]
    public CharacterController controller;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            isForward = true;
            isBackward = false;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            isBackward = true;
            isForward = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isBackward = false;
            isForward = false;
        }

        Vector3 moveDirection;
        if (isForward)
        {
            moveDirection = vrCamera.TransformDirection(Vector3.forward);
            controller.SimpleMove(moveDirection * speed);
        }
        if (isBackward)
        {
            moveDirection = vrCamera.TransformDirection(Vector3.back);
            controller.SimpleMove(moveDirection * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("We hit something!");
    }
}
