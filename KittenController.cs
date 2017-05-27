using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittenController : MonoBehaviour {

	static Animator anim;
	public float speed = 1.0f;
	public float rotationSpeed = 100.0f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0,rotation,0);

		if(Input.GetButtonDown("Jump")){
			anim.SetTrigger("KitJump");
		}
		if (translation != 0) {
			anim.SetBool ("KitWalk", true);
			anim.SetBool ("KitIdle", false);
		} else {
			anim.SetBool ("KitWalk", false);
			anim.SetBool ("KitIdle", true);
		}

		if(Input.GetKey ("Run")){
			anim.SetTrigger("KitRun");
		}
			
		if(Input.GetKey ("m")){
			anim.SetTrigger("KitMeow");
		}
		if(Input.GetKey ("c")){
			anim.SetTrigger("KitItching");
		}
	}
}
