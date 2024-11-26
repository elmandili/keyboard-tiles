using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float duration;
    public Color startColor;
    public Color endColor;
    private SpriteRenderer spriteRenderer;
    public Transform target;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MovePrefs();
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void MovePrefs()
    {
        rb.velocity = new Vector2(0, -speed);
    }
    IEnumerator ChangeColor()
    {
        float t = 0.0f;
        while (t < 1.0f)
        {
            t += 0.1f / Vector2.Distance(gameObject.transform.position, new Vector2(gameObject.transform.position.x, -3.5f));
            spriteRenderer.color = Color.Lerp(startColor, endColor, t);
            
            yield return null;
        }
        
    }
    public void DestoryGameObject()
    {
        Destroy(gameObject);
    }
    
}
