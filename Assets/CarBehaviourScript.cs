using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBehaviourScript : MonoBehaviour {

    private float timer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;

        pos.x = 5 * Mathf.Sin(timer);
        pos.z = 20 + Mathf.Sin(timer * 0.2f);

        transform.position = pos;

        timer += Time.deltaTime;
	}
}
