using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 7;
    [SerializeField]
    private float SmoothMoveTime = .1f;
    [SerializeField]
    private float TurnSpeed = 8;

    private float angle;
    private float smoothInputMagnitude;
    private float smoothMoveVelocity;
    private float inputMagnitude;

    private Vector3 velocity;
    private Vector3 inputDirection;


    private new Rigidbody rigidbody;

    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }
        checkMovement();
        
        velocity = transform.forward * MoveSpeed * smoothInputMagnitude;
        
        
    }

    void FixedUpdate()
    {
        if (inputMagnitude != 0)
        {
            rigidbody.MoveRotation(Quaternion.Euler(Vector3.up * angle));
            rigidbody.MovePosition(rigidbody.position + velocity * Time.deltaTime);
        }
        else
            rigidbody.MoveRotation(transform.rotation);

    }

    void checkMovement()
    {
        inputDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        inputMagnitude = inputDirection.magnitude;
        smoothInputMagnitude = Mathf.SmoothDamp(smoothInputMagnitude, inputMagnitude, ref smoothMoveVelocity, SmoothMoveTime);

        float targetAngle = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg;
        angle = Mathf.LerpAngle(angle, targetAngle, Time.deltaTime * TurnSpeed * inputMagnitude);
    }
}
