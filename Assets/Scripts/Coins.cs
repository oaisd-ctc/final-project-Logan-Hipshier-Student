using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    ScoreKeeper score;
    private void Awake()
    {
        score = GetComponent<ScoreKeeper>();        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            score.ModScore();
            Destroy(gameObject);
       
    }
}
