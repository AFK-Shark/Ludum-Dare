using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class RadioManager : MonoBehaviour
{
   [SerializeField] private AudioSource _radioSource;
   [SerializeField] private AudioClip[] _badClips;
   [SerializeField] private AudioClip _correctClip;
   [SerializeField] private Button _uiRadioButton;
   float rotation = 90f;
    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnButtonClick()
   {
       _uiRadioButton.transform.DOKill();
        _uiRadioButton.transform.DOLocalRotate(new Vector3(0, 0, _uiRadioButton.transform.rotation.z + rotation), 0.3f);
        Debug.Log(_uiRadioButton.transform.rotation.z);
    }
}
