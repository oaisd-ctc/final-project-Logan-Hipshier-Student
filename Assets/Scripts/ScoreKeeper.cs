using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score;
    static ScoreKeeper instance;
    void Awake()
    {
        ManageSingleton();
    }
    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        ResetScore();

    }
    public int GetScore()
    {
        return score;
    }
    public void ModScore()
    {
        score += 100;
        Debug.Log("Modded");
    }
    public void ResetScore()
    {
        score = 0;
    }
}
