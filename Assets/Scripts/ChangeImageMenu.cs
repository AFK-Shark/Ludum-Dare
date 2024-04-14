using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageMenu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel; 
    private Image targetImage; 

    public Sprite[] options; 

    void Start()
    {
        targetImage = GameObject.FindObjectOfType<ImageClick>()._anomaly;
        ShowMenu(false);
    }

    public void ShowMenu(bool show)
    {
        menuPanel.SetActive(show);
    }

    public void ChangeImage(int optionIndex)
    {
        if (optionIndex >= 0 && optionIndex < options.Length)
        {
            targetImage.sprite = options[optionIndex]; 
        }
        ShowMenu(false); 
    }
}