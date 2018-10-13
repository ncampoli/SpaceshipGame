using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{

    public GameObject myBullet;

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position += new Vector3(0, 0, -10) * Time.deltaTime;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            transform.position += new Vector3(0, 0, 10) * Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(myBullet, transform.position, transform.rotation);
        }
    }
}
