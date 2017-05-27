using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Litter_Box : MonoBehaviour {


	public GameObject poop;
	public GameObject character;
	public GameObject floor;
	public Vector3 position;
	public Button cleanBroom;


	void Start () 
	{
		Button broom = cleanBroom.GetComponent<Button>();
		broom.onClick.AddListener(HandleClick);

	}

	void OnTriggerEnter(Collider col){

		if(col.gameObject.tag == "toilet"){
			
		AnimalPoop();

		}

	}



	void AnimalPoop (){




		Vector3 position = new Vector3 (UnityEngine.Random.Range (25.5F, 26.5F), 255.65f, UnityEngine.Random.Range (-21.5F, -22.0F));

		Instantiate (poop, position, Quaternion.identity);


	}

	public void HandleClick() {

		Destroy (GameObject.FindWithTag("poop"));
	}

}
