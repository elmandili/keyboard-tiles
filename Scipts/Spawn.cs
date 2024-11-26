using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    public GameObject spawnObj;
    public float loopTime;
    public Transform RandomPos;
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    public Transform pos7;
    public Transform pos8;
    private int randomChoice;
    public LayerMask keyMask;
    public float minRange;
    public float maxRange;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoopSpawn());
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    // Function to spawn objects in random positions within for positions every "x" seconds
    private void spawn()
    {
        randomChoice = (int)Random.Range(1, 9);
        switch(randomChoice)
        {
            case 1:
                RandomPos = pos1;
                break;
            case 2:
                RandomPos = pos2;
                break;
            case 3:
                RandomPos = pos3;
                break;
            case 4:
                RandomPos = pos4;
                break;
            case 5:
                RandomPos = pos5;
                break;
            case 6:
                RandomPos = pos6;
                break;
            case 7:
                RandomPos = pos7;
                break;
            case 8:
                RandomPos = pos8;
                break;
        }
        
        GameObject spawn = Instantiate(spawnObj, RandomPos.position, Quaternion.identity);
        
        
    }
    IEnumerator LoopSpawn()
    {
        spawn();
        loopTime = Random.Range(minRange, maxRange);
        yield return new WaitForSeconds(loopTime);
        StartCoroutine(LoopSpawn());
    }
}
