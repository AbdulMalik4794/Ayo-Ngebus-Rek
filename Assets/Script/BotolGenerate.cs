using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotolGenerate : MonoBehaviour
{
    public GameObject botol;
	public Transform genetaionPoint;
	public float distanceBetween;

	private float botolWidth;
    // Start is called before the first frame update
    void Start()
    {
        botolWidth = botol.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < genetaionPoint.position.x)
        {
        	transform.position = new Vector3(transform.position.x + botolWidth 
        		+ distanceBetween, transform.position.y, transform.position.z);
        	Instantiate (botol, transform.position, transform.rotation);
        	//botol.transform.position = genetaionPoint.position;
        }
    }
}