using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Playermovement : MonoBehaviour
{
    public Text ui;
    public int score = 0;
    public LayerMask layerMask;
    private CharacterController controller;
    public float Speed = 3f;
    public float RotateSpeed = 0.2f;
    public float Gravity = -6f;
    private Vector3 Velocity = Vector3.zero;
    public Transform GroundCheck;
    public float CheckRadius = 1f;
    private bool IsGround;

    public float JumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        controller = transform.GetComponent<CharacterController>();
    }

    // Update is called once per frame
   
    private void move(){
        IsGround = Physics.CheckSphere(GroundCheck.position,CheckRadius,layerMask);
        if(IsGround && Velocity.y < 0){
            Velocity.y = 0;
        }

        if(IsGround && Input.GetButtonDown("Jump")){
            Velocity.y += Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }

        var Horizontal = Input.GetAxis("Horizontal");
        var Vertical = Input.GetAxis("Vertical");
        var move = transform.forward * Speed * Vertical * Time.deltaTime;
        controller.Move(move);
        transform.Rotate(Vector3.up,Horizontal* RotateSpeed);

        Velocity.y += Gravity * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
    }
     void Update()
    {
        move();
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag.Equals("coin")){
            
            score++;
            ui.text = "Score: "+score;
            Destroy(other.gameObject);
        }
         
    }
}
