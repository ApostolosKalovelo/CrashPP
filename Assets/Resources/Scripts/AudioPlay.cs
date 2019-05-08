using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour {

    public AudioClip MusicClip;
    public AudioSource MusicSource;
    GameObject cr = GameObject.Find("Crash2");
	// Use this for initialization
	void Start () {
        MusicSource.clip = MusicClip;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
