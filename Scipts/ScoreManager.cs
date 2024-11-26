using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI bestScoreTxt;
    public TextMeshProUGUI finalScoreTxt;
    private int bestScore;
    public int score;
    public GameObject addScorePref;
    public GameObject removeScorePref;
    public bool reset;
    
    
    public string bestScoreMod = "score";
    public string finalScoreMod = "final score";
    void Start()
    {
        
        //SaveManager.DeleteFile();

        SaveManager.LoadData();
        bestScoreTxt.text = "Best Score: " + GameManager.Instance.data.bestScore.ToString();
    }
    private void Update()
    {
        scoreTxt.text = score.ToString();
    }

    
    public void AddScore()
    {
        score += 10;
        GameObject addScoreAnim = Instantiate(addScorePref, new Vector2(0, -50), Quaternion.identity);
        StartCoroutine(DestroyAfter(addScoreAnim, 2f));
    }
    public void RemoveScore()
    {
        score -= 10;
        GameObject removeScoreAnim = Instantiate(removeScorePref, new Vector2(0, -50), Quaternion.identity);
        StartCoroutine(DestroyAfter(removeScoreAnim, 2f));
    }
    public void SetBestScore()
    {
        if(score > GameManager.Instance.data.bestScore)
        {
            bestScore = score;
            GameManager.Instance.data.bestScore = score;
            bestScoreTxt.text = "Best Score: " + GameManager.Instance.data.bestScore.ToString();
            SaveManager.SaveData();
        }
        
    }
    public void SetFianlScore()
    {
        //finalScoreTxt.text = "Your Score: " + score.ToString();
        PlayerPrefs.SetInt(finalScoreMod, score);
    }
    private IEnumerator DestroyAfter(GameObject gameObject, float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    
}
