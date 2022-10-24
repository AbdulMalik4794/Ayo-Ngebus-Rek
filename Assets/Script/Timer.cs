using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public float Second;
	public float Minute;
    private float CekSecond;
    public float DetikGantiNama;
	public int ScoreCheck;
	public int HighscoreCheck;
	public Text timerText;
    public Text namaJalan;
    public int bukaNextRute;
    public string[] namajalan;
    public Sprite[] ikonik;
    private SpriteRenderer spriteikon;
    public GameObject ikonikmove;
    public Transform posisiIkonMove;
    private int i = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        //namaJalan = GetComponent<Text>();
        spriteikon = ikonikmove.GetComponent<SpriteRenderer>();
        timerText = GetComponent<Text>();
        HighscoreCheck = PlayerPrefs.GetInt("Highscore");
        bukaNextRute = PlayerPrefs.GetInt("ruteAt");
    }

    // Update is called once per frame
    void Update()
    {
    	if(Second == 0 && Minute ==0)
    	{
    		if(Score.scoreAmount < ScoreCheck)
    		{
    			SceneManager.LoadScene("Game Over");
    		}
    		else if(Score.scoreAmount >= ScoreCheck)
    		{
    			if(Score.scoreAmount > HighscoreCheck)
    			{
    				PlayerPrefs.SetInt ("Highscore", Score.scoreAmount);
    			}

                PlayerPrefs.SetInt("ruteAt", bukaNextRute + 1);
    			SceneManager.LoadScene("Winner");
    		}
    	}
    	else
    	{
            if(Second <=0)
	    	{
	    		Second = 59;
	    		if(Minute>=1)
	    		{
                    namaJalan.text = namajalan[i];
                    i++;
                    CekSecond=1;
	    			Minute--;
	    		}
	    		else
	    		{
	    			Minute = 0;
	    			Second = 0;
	    		}
	    	}
            else if (CekSecond >= DetikGantiNama)
            {
                namaJalan.text = namajalan[i];
                spriteikon.sprite = ikonik[i];
                ikonikmove.transform.position = new Vector3(posisiIkonMove.position.x,
        		ikonikmove.transform.position.y, ikonikmove.transform.position.z);
                i++;
                CekSecond=0;
            }
	    	else
	    	{
                CekSecond += Time.deltaTime;
	    		Second -= Time.deltaTime;
	    	}
	    	timerText.text = Minute.ToString() +":"+ Second.ToString("f0");
	    }
    }
}
