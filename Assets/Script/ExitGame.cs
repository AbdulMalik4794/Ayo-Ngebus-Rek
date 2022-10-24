using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{
    public GameObject confirmPanel ;

    public void onUserClickYesNo(int pilihan)
    {
    	
    	if (pilihan == 1)
    	{
    		Application.Quit();
    	}
    	confirmPanel.gameObject.SetActive (false);
    }
    public void onClickQuit()
    {
    	confirmPanel.gameObject.SetActive (true);
    }
}