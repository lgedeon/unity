using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;

    //change physics and such here
    void FixedUpdate()
		{
		//Move the red block forward
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		
		//Move to the right
		if(Input.GetKey("d")) {
			rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		} 
		//Move to the left
		if(Input.GetKey("a")) {
			rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		} 
		if (rb.position.y < -10f) {
			FindObjectOfType<GameManager>().EndGame();
		}
    }
}
