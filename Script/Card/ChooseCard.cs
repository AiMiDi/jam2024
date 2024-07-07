using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ChooseCard : MonoBehaviour
{
    public GameObject CardBox;
    public GameObject Card;
    public GameObject select;
    private int chooseCardCount;
    public bool flag = false;
    
    public void AddCardBox()
    {
        CardBox = GameObject.Find("CardBox");
        chooseCardCount = CardBox.GetComponent<MyCards>().chooseCardCount;
        if (!flag)
        {
            if(chooseCardCount < 4)
            {
                CardBox.GetComponent<MyCards>().CardBox.Add(Card);
                CardBox.GetComponent<MyCards>().chooseCardCount++;
            }
            else
            {
                flag = !flag;
            }

        }
        else
        {
            CardBox.GetComponent<MyCards>().CardBox.Remove(Card);
            CardBox.GetComponent<MyCards>().chooseCardCount--;
        }
    }
    public void isChoose()
    {
        flag = !flag;
        select.SetActive(flag);
    }
    

}
