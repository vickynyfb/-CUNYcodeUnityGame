using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FeedTheAnimal : MonoBehaviour {

	public int rtime = 5;
	public GameObject poop;
	public GameObject bubble;
	public GameObject food;
	public Vector3 position;
	public Button cleanBroom;
	public Button activateFood;


	void Start () 
	{
		Button broom = cleanBroom.GetComponent<Button>();
		broom.onClick.AddListener(HandleClick);

		bubble.SetActive (false);

		Button Food = activateFood.GetComponent<Button>();
		Food.onClick.AddListener(Respawn);

	}

	void OnTriggerEnter(Collider other){

		AnimalHealthBar.health += 100;
		Debug.Log ("pickup");

		this.GetComponent<MeshCollider>().enabled = false;
		this.GetComponent<MeshRenderer>().enabled = false;
		bubble.SetActive (true);


		Invoke ("AnimalPoop", 5f);
		Invoke ("Bubble", 5f);

	}

	void Respawn(){
		this.GetComponent<MeshCollider>().enabled = true;
		this.GetComponent<MeshRenderer>().enabled = true;
//		food.SetActive(true);
		 


	}

	void Bubble(){
		this.bubble.SetActive (false);
	
	}


	void AnimalPoop (){

			Vector3 position = new Vector3 (UnityEngine.Random.Range (25.5F, 26.5F), 255.65f, UnityEngine.Random.Range (-21.5F, -22.0F));

			Instantiate (poop, position, Quaternion.identity);
	}

	public void HandleClick() {

		Destroy (GameObject.FindWithTag("poop"));

	}
		
}
