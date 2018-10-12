using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Health healthScript;
    public Text healthTxt;
    public Slider healthBar;

    public Text scoreNum;
    public Text timeNum;
    static int score;

	void Start ()
    {
        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = healthScript.getHealth().ToString();
	}
	
    public static void updateScore(int amount)
    {
        score += amount;
    }

	void Update ()
    {
        healthBar.value = healthScript.getHealth();
        healthTxt.text = healthScript.getHealth().ToString();
        timeNum.text = ((int)Time.time).ToString();
        scoreNum.text = score.ToString();
    }
}
