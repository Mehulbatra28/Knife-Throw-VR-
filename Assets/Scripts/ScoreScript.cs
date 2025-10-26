using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TMP_Text Score;
    public int CurrentScore;
    public static ScoreScript instance;

    public void Awake()
    {
        instance = this;
    }


    public void ScoreAdd(int amount)
    {
        CurrentScore += amount;
        Score.text ="Score:"+ CurrentScore.ToString();

    }
}
