using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public bool CanFly = false;

    private CharacterController controller;
    public float Speed = 10f;
    public float Speed1 = 5f;
    public float RotateSpeed = 2f;
    public float Gravity = -9.8f;
    private Vector3 Velocity = Vector3.zero;
    public Transform GroundCheck;
    public float CheckRadius = 0.2f;
    private bool IsGround;
    public LayerMask layerMask;

    public float JumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        controller = transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        IsGround = Physics.CheckSphere(GroundCheck.position, CheckRadius, layerMask);
        if(IsGround && Velocity.y < 0)
        {
            Velocity.y = 0;
        }

        if(IsGround && Input.GetButtonDown("Jump"))
        {
            Velocity.y +=   Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }else if(CanFly && Input.GetButtonDown("Jump"))
        {
            Velocity.y = 0;
            Velocity.y +=   Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }


        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");


        var move = transform.forward * Speed * vertical * Time.deltaTime;
        controller.Move(move);

        Velocity.y += Gravity * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
        var move1 = transform.right * Speed1 * horizontal * Time.deltaTime;
        controller.Move(move1);

        if(Input.GetKey(KeyCode.E))
        {
        	transform.Rotate(Vector3.up*Time.deltaTime*100);
        }

        if(Input.GetAxis("Mouse ScrollWheel") < 0)
        {
           	transform.Rotate(Vector3.up*Time.deltaTime*800);
        }

        if(Input.GetKey(KeyCode.Q))
        {
        	transform.Rotate(Vector3.down*Time.deltaTime*100);
    	}

    	if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
           	transform.Rotate(Vector3.down*Time.deltaTime*800);
       	}

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.transform.CompareTag("Finish"))
        {
            hit.rigidbody.AddForce(transform.forward * 2 * Speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("FlayBall")){
            CanFly = true;
            Destroy(other.gameObject);
        }
    }
}
