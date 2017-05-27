using UnityEngine;
using System.Collections;

public class pickKitten : MonoBehaviour {


	public void ClickScene() {

		Application.LoadLevel ("Kitten");
		PlayerPrefs.SetString ("pet", "kitten");
		PlayerPrefs.SetFloat ("petLocationX",16f);
		PlayerPrefs.SetFloat ("petLocationY", 256f);
		PlayerPrefs.SetFloat ("petLocationZ", -22.5f);

	}

	// Update is called once per frame
	void Update () {

	}
}