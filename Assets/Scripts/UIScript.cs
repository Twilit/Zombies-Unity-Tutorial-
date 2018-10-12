using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Health healthScript;
    public Text healthTxt;
    public Slider healthBar;
    public GameObject losePanel;
    public Text scoreNum;
    public Text timeNum;
    static int score;

	void Start ()
    {
        GameManager manager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        healthBar = manager.playerHealth;
        healthTxt = manager.playerHealthTxt;
        scoreNum = manager.score;
        timeNum = manager.timeTxt;

        healthBar.maxValue = healthScript.getMaxHealth();
        healthBar.value = healthScript.getHealth();
        healthTxt.text = healthScript.getHealth().ToString();

        StartCoroutine("updateUI");
    }
	
    public static void updateScore(int amount)
    {
        score += amount;
    }

    IEnumerator updateUI()
    {
        healthBar.value = healthScript.getHealth();
        healthTxt.text = healthScript.getHealth().ToString();
        timeNum.text = ((int)Time.time).ToString();
        scoreNum.text = score.ToString();

        if (healthScript.IsDead)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }

        yield return new WaitForSeconds(0.5f);
        StartCoroutine("updateUI");
    }

	void Update ()
    {
        /*healthBar.value = healthScript.getHealth();
        healthTxt.text = healthScript.getHealth().ToString();
        timeNum.text = ((int)Time.time).ToString();
        scoreNum.text = score.ToString();*/
    }
}
