using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecrashstate : MonoBehaviour {
    GameObject Crash;
    GameObject Crash2;
    // Use this for initialization
    void Start ()
    {
         Crash = GameObject.Find("Crash");
         Crash2 = GameObject.Find("Crash2");
         //apenergopoihse ton Crash2,afou to wumpa einai makria
         Crash2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //an h apostasi metaksi crash kai wumpa einai mikri,tote energopoihse ton crash 2
        //apenergopoihse ton crash
        if (Vector3.Distance(GameObject.FindGameObjectWithTag("Crash").transform.position,
            GameObject.FindGameObjectWithTag("Fruit").transform.position) < 40  )
        {
            Crash.SetActive(false);
            Crash2.SetActive(true);
        }
    }




}
