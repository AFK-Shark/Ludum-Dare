using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class ImageClick : MonoBehaviour, IPointerClickHandler 
{
    
    [SerializeField] ChangeImageMenu menuManager;
   [HideInInspector] public Image _anomaly;
   [HideInInspector] public int _anomalyIndex;

    private void Awake()
    {
       _anomaly = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
        menuManager.ShowMenu(true);
    }
}
