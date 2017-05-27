using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour {

	public AudioSource source;
	public AudioClip hover;
	public AudioClip click;


	public void OnHover(){
		source.PlayOneShot(hover);

	}

	public void OnClick(){
		source.PlayOneShot(click);

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
