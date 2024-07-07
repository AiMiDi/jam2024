using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CardCreater : MonoBehaviour
{
    public CardSciptObject cardMessage;
    public Image cardArt;
    public Image cardType;

    public void Start()
    {
        cardArt.sprite = cardMessage.cardArt;
        cardType.sprite = cardMessage.cardType; 
    }
}
