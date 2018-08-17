using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFollow : MonoBehaviour
{
    public GameObject UIGameObject;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 texPos = Camera.main.WorldToScreenPoint(this.transform.position);
        UIGameObject.transform.position = texPos;
	}
}
