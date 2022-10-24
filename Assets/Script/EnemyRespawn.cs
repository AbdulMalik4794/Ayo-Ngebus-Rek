using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    public GameObject WarningSign;
    public GameObject move;
    public GameObject npc;
    public GameObject posB;
	public Transform genetaionPoint;
	public float DetikMove;
	private float timermover;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(timermover >= DetikMove)
        {
            WarningSign.gameObject.SetActive (true);
        	move.transform.position = new Vector3(genetaionPoint.position.x,
        		move.transform.position.y, move.transform.position.z);
        	npc.transform.position = new Vector3(genetaionPoint.position.x,
        		npc.transform.position.y, npc.transform.position.z);
        	posB.transform.position = new Vector3(genetaionPoint.position.x,
        		posB.transform.position.y, posB.transform.position.z);
        	timermover = 0;
        }
        timermover += Time.deltaTime;
    }
}
