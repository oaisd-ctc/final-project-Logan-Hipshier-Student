using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenerator : MonoBehaviour
{

   

    public Transform[] segments;

   
    float unit;
    float increment;
    
    private void Awake()
    {
        unit = 73;
        increment = 73;
        

        SpawnLevelPart(new Vector3(33, -8f));
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
            SpawnLevelPart(new Vector3(33, -8f) + new Vector3(unit, 0));
            unit += increment;
            Debug.Log("Touched Checkpoint");
       
    }

   
    private void SpawnLevelPart(Vector3 spawnPosition)
    {
        int index = Random.Range(0,4);
        Instantiate(segments[index], spawnPosition,Quaternion.identity);
    }
    
   
}
