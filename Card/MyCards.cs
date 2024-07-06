using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MyCards : MonoBehaviour
{
    public List<GameObject> CardBox;
    public List<GameObject> CardList;
    public GameObject newCard;
    public GameObject CardManager;
    public Transform cardCanves;
    public bool flag;

    public void showCardBox()
    {
        int maxNum = CardBox.Count;
        int num = 1;

        foreach (var card in CardBox)
        {
            GameObject A;
            newCard.GetComponent<CardCreater>().cardMessage = card.GetComponent<CardCreater>().cardMessage;
            int dir;
            if (num <= maxNum / 2 && maxNum!=1)
            {
                A = Instantiate(newCard, new Vector3(600, -200, 0), Quaternion.Euler(0,0,(30/(maxNum/2)*(maxNum+1 / 2-num))), cardCanves);
                dir = -1;
            }else if (num == maxNum/2 ||(num == maxNum / 2+1 && maxNum%2!=0) || maxNum ==1)
            {
                A = Instantiate(newCard, new Vector3(600 , -200, 0), Quaternion.Euler(0, 0, 0), cardCanves);
                dir = 0;
            }
            else
            {
                A = Instantiate(newCard, new Vector3(600, -200, 0), Quaternion.Euler(0, 0, -(30 / (maxNum / 2) * (num+1-maxNum / 2 ))), cardCanves);
                dir = 1;
            }
            
            A.transform.DOMove(new Vector3(800+dir*Mathf.Abs(maxNum/2+1-num)*65,150,0),1);
            A.GetComponent<SelectHandCard>().position = new Vector3(800 + dir * Mathf.Abs(maxNum / 2+1 - num) * 65, 150,0);
            A.GetComponent<SelectHandCard>().rotation = A.transform.rotation;
            A.GetComponent<SelectHandCard>().scale = new Vector3(0.5f,0.5f,0.5f);
            CardList.Add(A);
            
            num++;
        }


       
        
        CardBox.Clear();
        foreach (var card in CardManager.GetComponent<CreatCardManage>().cards)
        {
            Destroy(card);
        }
        CardManager.GetComponent<CreatCardManage>().cards.Clear();
    }

    
}

