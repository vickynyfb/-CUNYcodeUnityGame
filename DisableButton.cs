using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{

    public string componentName;
    private GameObject obj;


    // Use this for initialization
    void Start()
    {

        obj = GameObject.Find(componentName);
		obj.SetActive(false);

    }

    public void disable()
    {

        if (obj.activeSelf == true)
        {
            Debug.Log("Button is Active");
            Debug.Log("Will Hide MenuButton");
            obj.SetActive(false);


        }
        else
        {
            Debug.Log("Button is inActive");
            Debug.Log("Will Show MenuButton");
            obj.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {


    }
}
