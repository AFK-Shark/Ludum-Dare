using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

static class AnomalyActivityScore 
{
    
    private static int _score = 50;
    
    

    public static int Score
    {
        get => _score;
        set => _score = value;
    }


    private static void Awake()
    {
        LoadScore();
        
    }

    public static void OnValueChanged(bool IsCorrect)
    {
        if (IsCorrect)
        {
            _score += 20;
        }
        else
        {
            _score -= 30;

        }
    }

    public static void SaveScore() // если идет переход на другую сцену вызвать этот метод
    {
        PlayerPrefs.SetInt("score", _score);
    }

    private static void LoadScore()
    {
       
        int score = PlayerPrefs.GetInt("score");

        if (score != 0)
        {
            _score = score;
        }
        else
        {
            _score = 50;
        }
    }

   
    
}
