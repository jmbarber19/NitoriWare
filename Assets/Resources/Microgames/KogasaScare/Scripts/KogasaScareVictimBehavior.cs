﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KogasaScareVictimBehavior : MonoBehaviour {

    public Transform victimTransform;
    public float minvictimspawnx; //-4.64
    public float maxvictimspawnx; // 4.64
    public float xspawn;
    Vector2 pos;

    // Use this for initialization
    void Start () {
        victimTransform = GetComponent<Transform>();
        xspawn = Random.Range(minvictimspawnx, maxvictimspawnx);
        pos = new Vector2(xspawn, -0.55f);
        victimTransform.position = pos;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    collide(other);
    //}

    //void OnTriggerStay2D(Collider2D other)
    //{
    //    collide(other);
    //}

    //void collide(Collider2D other)
    //{
    //    var kogasaBehavior = other.GetComponent<KogasaScareKogasaBehaviour>();
    //    //if ( == true && other.name == "KogasaObject")
    //    //{
    //    //    destroy(gameobject);
    //    //}
    //}

}
