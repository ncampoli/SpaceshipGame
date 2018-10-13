using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float myTimer = 1.0f;

	// Update is called once per frame
	void Update ()
    {
        transform.position += new Vector3(0, 0, -25) * Time.deltaTime;

        if (myTimer > 0)
        {
            myTimer = myTimer - Time.deltaTime;
        }

        if (myTimer <= 0)
        {
            Destroy(this.gameObject);
        }

    }
}

