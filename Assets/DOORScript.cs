using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOORScript : MonoBehaviour {

    private Vector3 initialPosition;
	// Use this for initialization
	void Start () {
        initialPosition = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
        // transform.position = new Vector3 (Mathf.Sin(Time.time) * 2.0f + initialPosition.x, initialPosition.y, initialPosition.z);
        Debug.Log(transform.position.x);
        if (transform.position.x < -132.0f ){
            transform.position = new Vector3(transform.position.x+0.01f, initialPosition.y, initialPosition.z);
        }
    }
}
