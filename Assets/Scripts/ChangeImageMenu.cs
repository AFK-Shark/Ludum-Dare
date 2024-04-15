using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeImageMenu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel; 
    private Image targetImage;
    [SerializeField] private int _correctId;
    public Sprite[] options;
    [SerializeField] private TMP_Text _score;
    private GameObject _imageMenu;

    void Start()
    {
        
        targetImage = GameObject.FindObjectOfType<ImageClick>()._anomaly;
        ShowMenu(false);
        _score.text = $"Score: {AnomalyActivityScore.Score}";
    }

    public void ShowMenu(bool show)
    {
        menuPanel.SetActive(show);
    }
    public void CloseMenu()
    {
        gameObject.SetActive(false);
    }

    public void ChangeImage(int optionIndex)
    {
        if (optionIndex >= 0 && optionIndex < options.Length)
        {
            targetImage.sprite = options[optionIndex];
            ShowMenu(false);
            if (optionIndex == _correctId)
            {
                AnomalyActivityScore.OnValueChanged(true);
                _score.text = $"Score: {AnomalyActivityScore.Score}";
            }
            else
            {
                AnomalyActivityScore.OnValueChanged(false);
                if (AnomalyActivityScore.Score <= 0)
                {
                    Defeat();
                }
                _score.text = $"Score: {AnomalyActivityScore.Score}";
            }
        }
        
    }

    public void Defeat()
    {
        SceneManager.LoadScene(5);
    }
}