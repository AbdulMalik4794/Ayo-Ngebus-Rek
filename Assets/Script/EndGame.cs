using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
	public Text textScore;
	public Text textHighScore;

    // Start is called before the first frame update
    void Start()
    {
    	textScore.text = "Score : "+ Score.scoreAmount;
        textHighScore.text = "Highscore :" + PlayerPrefs.GetInt ("Highscore");
    }
}