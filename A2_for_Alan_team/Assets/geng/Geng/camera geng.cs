using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform player;
   private float mouseX,mouseY;
   public float mouseSensitivity;
   public float xRotation;

   private void Update (){
    mouseX = Input.GetAxis("Mouse X") * mouseSensitivity*Time.deltaTime;
    mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity*Time.deltaTime;

    xRotation -= mouseY;
    player.Rotate(Vector3.up * mouseX);
    transform.localRotation = Quaternion.Euler(xRotation,0,0);
   }
}
