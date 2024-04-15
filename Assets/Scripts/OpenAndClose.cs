using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenAndClose : MonoBehaviour
{
    public GameObject image;
    public Button openButton;
    public Button closeButton;

    void Start()
    {
        openButton.onClick.AddListener(OpenImage);
        closeButton.onClick.AddListener(CloseImage);
    }

    void OpenImage()
    {
        image.SetActive(true);
    }

    void CloseImage()
    {
        image.SetActive(false);
    }


}
