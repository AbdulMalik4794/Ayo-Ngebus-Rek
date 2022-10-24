using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
	public GameObject confirmPanel ;

    public void onUserClickYesNo(int pilihan)
    {
    	
    	if (pilihan == 1)
    	{
    		PlayerPrefs.DeleteKey("ruteAt");
    		PlayerPrefs.DeleteKey("Highscore");
    	}
    	confirmPanel.gameObject.SetActive (false);
    }
    public void onClickReset()
    {
    	confirmPanel.gameObject.SetActive (true);
    }
}
