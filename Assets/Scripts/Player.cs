using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision newCollision)
    {
        if (newCollision.gameObject.name == "Cube")
        {
            this.GetComponent<AudioSource>().Play();
        }
    }
}
