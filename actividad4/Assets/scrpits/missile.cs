using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () 
    {


        this.transform.Translate(Vector3.forward * speed);

	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision detectada");

                
       
    }
}

