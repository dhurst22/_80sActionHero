﻿using UnityEngine;
using System.Collections;

public class HeroStartPoint : MonoBehaviour {

    private HeroMovement hero;
    private CameraFollow cam;

    // Use this for initialization
	void Start ()
    {
        hero = FindObjectOfType<HeroMovement>();
        hero.transform.position = transform.position;

        cam = FindObjectOfType<CameraFollow>();
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}