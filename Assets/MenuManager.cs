using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private Ease motionType;
    [SerializeField] private Image hand;
    
    void Start()
    {
        textMeshProUGUI.transform.DOScale(1.2f, 0.5f).SetLoops(1000, LoopType.Yoyo).SetEase(motionType);

        hand.transform.DOMoveX(0.23f, 0.5f).SetLoops(1000, LoopType.Yoyo).SetEase(motionType);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
