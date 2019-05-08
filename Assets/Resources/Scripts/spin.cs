using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {
    //taxitita svouras
    float speed = 60;


	// Update is called once per frame
	void Update () {
        //gyrna ston aksona Y synexws
        transform.Rotate(0, speed, 0);


    }

}