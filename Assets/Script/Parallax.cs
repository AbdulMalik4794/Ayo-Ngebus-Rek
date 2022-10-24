﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float backgroundSize;

	private Transform cameraTransform;
	private Transform[] layers;
	private float viewZone = 10;
	private int leftIndex;
	private int rightIndex;

    // Start is called before the first frame update
    void Start()
    {
    	cameraTransform =  Camera.main.transform;
        layers = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++){
        	layers[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraTransform.position.x < (layers[leftIndex].
            transform.position.x + viewZone))
        {
        	ScrollLeft();
        }
        if (cameraTransform.position.x > (layers[rightIndex].
            transform.position.x - viewZone))
        {
        	ScrollRight();
        }
    }

    void ScrollLeft()
    {
    	int lastRight = rightIndex;
    	layers[rightIndex].position = Vector3.right*(layers[leftIndex].
            position.x-backgroundSize);
    	leftIndex = rightIndex;
    	rightIndex--;
    	if (rightIndex < 0)
    	{
    		rightIndex = layers.Length-1;
    	}
    }

    void ScrollRight()
    {
    	int lastLeft = leftIndex;
    	layers[leftIndex].position = Vector3.right*(layers[rightIndex].
            position.x + backgroundSize);
    	rightIndex = leftIndex;
    	leftIndex++;
    	if (leftIndex == layers.Length)
    	{
    		leftIndex = 0;
    	}
    }
}