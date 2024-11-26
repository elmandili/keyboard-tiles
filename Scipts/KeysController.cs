using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeysController : MonoBehaviour
{
    public KeyCode key;
    public LayerMask pref;

    public Rigidbody2D rb;
    public Collider2D coll;
    public SpriteRenderer spriteRenderer;

    public Loose loose;
    public ScoreManager scoreManager;

    private AudioSource audioSource;
    
    public float startAudioTime;
    public float endAudioTime;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CircleCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyPrefs();
        ChangeKeyAlpha();
    }
    //Detect the targets and destroy them after clicking the apropriate key
    private void DestroyPrefs()
    {
        Collider2D hitPref = Physics2D.OverlapCircle(coll.bounds.center, coll.bounds.extents.x, pref);
        if (hitPref && Input.GetKeyDown(key) && !loose.loose)
        {
            scoreManager.AddScore();
            hitPref.GetComponent<Animator>().SetTrigger("Destroy");
            hitPref.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            hitPref.GetComponent<BoxCollider2D>().enabled = false;
            
            audioSource.Play();
            
        }
        if (Input.GetKeyDown(key) && !hitPref && !loose.loose)
            scoreManager.RemoveScore();

    }
    //Change the Opacity of the Main Keys
    private void ChangeKeyAlpha()
    {

        if (Input.GetKeyDown(key) && !loose.loose)
        {
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1f);
            
            //print("alpha 1");
        }
        if(Input.GetKeyUp(key))
        {
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0.5f);
            //print("alpha .5");
        }
    }
    
}
