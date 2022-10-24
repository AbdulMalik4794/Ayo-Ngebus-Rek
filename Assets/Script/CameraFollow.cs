﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerPos;
	public float smoothness;
	public Vector3 Velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
		Vector3 target = new Vector3(playerPos.position.x, 0f, -10f);
		transform.position = Vector3.SmoothDamp(transform.position, 
			target, ref Velocity, smoothness);
	}
}