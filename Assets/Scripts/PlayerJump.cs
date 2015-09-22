using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour
{
	private float jump = 25f;
	private bool InAir=false;

	void FixedUpdate () 
	{
		//float x = Input.GetAxis("Horizontal");
		//float z = Input.GetAxis ("Vertical");
		
		//Vector3 pos = new Vector3 (x, 0f, z);
	}
	
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Floor"&&InAir==true){
			InAir = false;
		}
	}
	
	void OnCollisionStay(Collision other){
		if (other.gameObject.tag == "Floor" && InAir == true) {
			InAir = false;
		}
	}
	
	void OnCollisionExit(Collision other)
	{
		InAir = true;
	}
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)&&InAir==false) 
		{
			this.rigidbody.AddForce(new Vector3(0,jump,0));
		}
		if (Input.GetKeyDown (KeyCode.W)&&InAir==false) 
		{
			this.rigidbody.AddForce(new Vector3(0,jump,0));
		}
	}
}