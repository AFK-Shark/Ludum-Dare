using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnomalyActivityScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    private static int _score = 50;

    
    private void Awake()
    {
        LoadScore();
        _scoreText.text = $"Score: {_score}";
    }

    public void OnValueChanged(bool IsCorrect)
    {
        if (IsCorrect)
        {
            _scoreText.text = $"Score: {_score += 20}"; ;
        }
        else
        {
            _scoreText.text = $"Score: {_score -= 30}"; 
            
        }
    }

    public void SaveScore() // если идет переход на другую сцену вызвать этот метод
    {
        PlayerPrefs.SetInt("score", _score);
    }

    private void LoadScore()
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

    public void Defeat()
    {
        // загрузить сцену проигрыша
    }
    
}
