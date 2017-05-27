using UnityEngine;
using System;
using System.Globalization;
using System.Collections;

public class AutoIntensity : MonoBehaviour {

	public Gradient nightDayColor;

	public float maxIntensity = 3f;
	public float minIntensity = 0f;
	public float minPoint = -0.2f;

	public float maxAmbient = 1f;
	public float minAmbient = 0f;
	public float minAmbientPoint = -0.2f;


	public Gradient nightDayFogColor;
	public AnimationCurve fogDensityCurve;
	public float fogScale = 1f;

	public float dayAtmosphereThickness = 0.4f;
	public float nightAtmosphereThickness = 0.87f;


	float skySpeed = 1;

	Light mainLight;
	Skybox sky;
	Material skyMat;

	float mapping (float s, float a1, float a2, float b1, float b2){

		return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
	}

	void Start () 
	{
		InvokeRepeating ("LaunchSun", 0f, 60f);
		mainLight = GetComponent<Light>();
		skyMat = RenderSettings.skybox;

		float timeOfDay = (float)DateTime.Now.Hour + (float)DateTime.Now.Minute * 0.01f;

	}

	void LaunchSun () 
	{	
		
		float tRange = 1 - minPoint;
		float dot = Mathf.Clamp01 ((Vector3.Dot (mainLight.transform.forward, Vector3.down) - minPoint) / tRange);
		float i = ((maxIntensity - minIntensity) * dot) + minIntensity;

		mainLight.intensity = i;

		tRange = 1 - minAmbientPoint;
		dot = Mathf.Clamp01 ((Vector3.Dot (mainLight.transform.forward, Vector3.down) - minAmbientPoint) / tRange);
		i = ((maxAmbient - minAmbient) * dot) + minAmbient;
		RenderSettings.ambientIntensity = i;

		mainLight.color = nightDayColor.Evaluate(dot);
		RenderSettings.ambientLight = mainLight.color;

		RenderSettings.fogColor = nightDayFogColor.Evaluate(dot);
		RenderSettings.fogDensity = fogDensityCurve.Evaluate(dot) * fogScale;

		i = ((dayAtmosphereThickness - nightAtmosphereThickness) * dot) + nightAtmosphereThickness;
		skyMat.SetFloat ("_AtmosphereThickness", i);


		float timeOfDay = (float)DateTime.Now.Hour + (float)DateTime.Now.Minute * 0.01f;
		float xrotation = mapping (timeOfDay, 0f, 24f, 0f, 360f);

		transform.eulerAngles = new Vector3 (xrotation - 90f, transform.rotation.y, transform.rotation.z);

		if (Input.GetKeyDown (KeyCode.Q)) skySpeed *= 0.5f;
		if (Input.GetKeyDown (KeyCode.E)) skySpeed *= 2f;


	}
}