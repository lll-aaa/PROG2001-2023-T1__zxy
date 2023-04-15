using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character_zxy: MonoBehaviour
{
    public Image TargetImage;
    private CharacterController controller;
    public float Speed = 10f;
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
        PlayerMove01();
        if (Velocity.y < 0)
        {
            float a = -20 - Velocity.y;
            float num = -20;
            TargetImage.fillAmount = Mathf.Lerp(0, 1, a / num);
        }
        else
        {
            TargetImage.fillAmount = 1;
        }
    }

    private void PlayerMove01()
    {

        IsGround = Physics.CheckSphere(GroundCheck.position, CheckRadius, layerMask);
        if (IsGround && Velocity.y < 0)
        {
            Velocity.y = 0;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (Velocity.y < 0)
            {
                Velocity.y = 0;
            }
            Velocity.y += Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var move = transform.forward * Speed * vertical * Time.deltaTime;
        controller.Move(move);
        if (Velocity.y > -20)
        {
            Velocity.y += Gravity * Time.deltaTime;
        }
       
        controller.Move(Velocity * Time.deltaTime);
        transform.Rotate(Vector3.up, horizontal * RotateSpeed);
    }
}



