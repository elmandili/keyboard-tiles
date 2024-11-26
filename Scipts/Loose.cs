using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loose : MonoBehaviour
{
    private Rigidbody2D rb;
    public Collider2D coll;

    public Canvas looseCanv;
    public LayerMask Prefs;

    public SpawnController spawnController;
    public ScoreManager scoreManager;

    public bool loose;
    // Start is called before the first frame update
    private void Start()
    {
        loose = false;
    }
    private void FixedUpdate()
    {
        
    }
    private void Update()
    {
        LooseFunc();
    }
    // Update is called once per frame

    private void LooseFunc()
    {
        Collider2D hitPrefs = Physics2D.OverlapBox(coll.bounds.center, coll.bounds.size, 0f, Prefs);
        if(hitPrefs)
        {
            Time.timeScale = 0;
            loose = true;
            looseCanv.gameObject.SetActive(true);
        }
        scoreManager.SetFianlScore();
        scoreManager.SetBestScore();
        
    }

    
}
