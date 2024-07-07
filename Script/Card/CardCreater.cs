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
    public TMP_Text cardName;
    public TMP_Text ATK;
    public TMP_Text armor;

    public void Start()
    {
        cardArt.sprite = cardMessage.cardArt;
        cardType.sprite = cardMessage.cardType; 
        cardName.text = cardMessage.cardName;
        if(cardMessage.ATK!=0)
            ATK.text = cardMessage.ATK.ToString();
        if(cardMessage.armor!=0)
            armor.text = cardMessage.armor.ToString();
    }
}
