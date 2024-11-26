using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreAnimation : MonoBehaviour
{
    public ScoreManager scoreManager;
    private int reachedScore = 0;
    public TextMeshProUGUI finalScoreTxt;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeSelf && reachedScore < PlayerPrefs.GetInt(scoreManager.finalScoreMod))
        {
            //reachedScore = Mathf.Min(PlayerPrefs.GetInt(scoreManager.finalScoreMod), reachedScore + (int)(speed));
            reachedScore += speed;
            finalScoreTxt.text = "Your Score: " + reachedScore.ToString();
            print("final score : " + PlayerPrefs.GetString(scoreManager.finalScoreMod));
            
        }
        
    }
}
