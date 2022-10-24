using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningSign : MonoBehaviour
{
	public GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Blink(item));
    }

    // Update is called once per frame
    void Update()
    {
    	StartCoroutine(Blink(item));
    }

    IEnumerator Blink(GameObject obj)
    {
        Renderer objRenderer = obj.GetComponent<Renderer>();
        objRenderer.enabled = false;
        yield return new WaitForSeconds(0.1f);
        objRenderer.enabled = true;
        yield return new WaitForSeconds(0.5f);
    }
}
