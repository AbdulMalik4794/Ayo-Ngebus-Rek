using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuteSelect : MonoBehaviour
{

	public Button[] ruteButton;
	public Sprite buttonlock;
    // Start is called before the first frame update
    void Start()
    {
        int ruteAt = PlayerPrefs.GetInt("ruteAt");
        for (int i = 0; i < ruteButton.Length; i++)
        {
            if (i > ruteAt)
            {
                ruteButton[i].interactable = false;
                ruteButton[i].GetComponentInChildren<Text>().text = "";
                ruteButton[i].GetComponent<Image>().sprite = buttonlock;
            }
        }
    }
}
