using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHealthBar : MonoBehaviour {

	public static int health = 100;
	public static GameObject player;
	public Slider healthBar;
	public GameObject denger;
	public GameObject hunger;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("ReduceHealth", 1, 1);
//		denger.SetActive (false);
		
	}

	void ReduceHealth(){
	
		health = health - 2;
		healthBar.value = health;
		if (health <= 70) {
			hunger.SetActive (true);
			if (health <= 10) {
				denger.SetActive (true);
				if (health <= 0) {
					Application.LoadLevel ("TheEndScene");
				}
			}
		} else {

			denger.SetActive (false);
			hunger.SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
