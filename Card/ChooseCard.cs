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
    public bool flag = false;
    
    public void AddCardBox()
    {
        CardBox = GameObject.Find("CardBox");
        if (!flag)
        {
            CardBox.GetComponent<MyCards>().CardBox.Add(Card);
        }
        else
        {
            CardBox.GetComponent<MyCards>().CardBox.Remove(Card);
        }
    }
    public void isChoose()
    {
        flag = !flag;
        select.SetActive(flag);
    }
    

}
