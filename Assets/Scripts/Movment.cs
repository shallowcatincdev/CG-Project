using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movment : MonoBehaviour
{
    public Transform orientation;
    public Transform camTransform;
    float moveSpeed = 1;

    Vector3 moveDirection;
    Vector2 inputDirection;
    Vector2 rotation;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnMove(InputValue value)
    {
        inputDirection = value.Get<Vector2>();

    }



    void MovePlayer()
    {
        moveDirection = orientation.forward * inputDirection.y + orientation.right * inputDirection.x;
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    public void OnCamera(InputValue value)
    { 

        rotation.y += value.Get<Vector2>().x * 0.5f;
        rotation.x -= value.Get<Vector2>().y * 0.5f;
        rotation.x = Mathf.Clamp(rotation.x, -90f, 90f);

        camTransform.rotation = Quaternion.Euler(rotation.x, rotation.y, 0);
        orientation.rotation = Quaternion.Euler(0, rotation.y, 0);
    }

}
