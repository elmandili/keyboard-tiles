using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    public float addScale;
    public Spawn spawn;
    public float maxScale;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0.5f;
        InvokeRepeating("IncreaseTimeScale", 10, 5);
    }

    // Update is called once per frame
    private void IncreaseTimeScale()
    {
        if(Time.timeScale < maxScale)
        {
            Time.timeScale += addScale;
        }
        
        if (spawn.minRange > 0.5f)
        {
            spawn.minRange -= 0.3f;
            print(spawn.minRange);
        }
        

        if (spawn.maxRange > 1f)
        {
            spawn.maxRange -= 0.1f;
            print(spawn.maxRange);
        }
            
        print("Scale Added");
    }
    
}
