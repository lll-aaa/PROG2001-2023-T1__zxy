using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class playermove : MonoBehaviour
{
private CharacterController Controller;
 public float Speed = 10f;
 public float RotateSpeed = 1f;
public float Gravity = -9.8f;
private Vector3 Velocity = Vector3.zero;
public Transform GroundCheck;
public float CheckRadius = 0.2f;
private bool IsGround;
public LayerMask layerMask;
public float JumpHeight = 3f;
public TMP_Text ui;
 public int score = 0;
 public GameObject CCC;

void Start()
 {
 Controller = transform.GetComponent<CharacterController>();
}

    // Update is called once per frame

  private void Move()
{
 IsGround = Physics.CheckSphere(GroundCheck.position,CheckRadius,layerMask);
 if(IsGround && Velocity.y < 0)
{
Velocity.y = 0;
}

        if (Velocity.y <= -25 && Input.GetButtonDown("Jump"))
        {
            Velocity.y = 0;
            Velocity.y += Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }

        var horizontal = Input.GetAxis("Horizontal");
        var Vertical = Input.GetAxis("Vertical");
        var move = transform.forward * Speed * Vertical * Time.deltaTime;
 Controller.Move(move);
 Velocity.y += Gravity * Time.deltaTime;
     Controller.Move(Velocity * Time.deltaTime);
     transform.Rotate(Vector3.up, horizontal * RotateSpeed);
 }
void Update()
{

      Move();
}
private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag.Equals("coin")){
            
            score++;
            ui.text = "Score: "+score;
            Destroy(other.gameObject);
              if(score == 5){
            CCC.SetActive(true);
        }
        }
         
    }
    public void v()
    {
      
        
    }
}

