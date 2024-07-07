using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatCardManage: MonoBehaviour
{
    public GameObject newCard;
    public Transform cardCanves;
    public List<CardSciptObject> cardMessageList;
    public List<GameObject> cards = new List<GameObject>();
    public int count = 0;

    private void Start()
    {
       CreatNewCard();
    }

    public void CreatNewCard()
    {
        int num = 0;
        for (int i = 1; i<=8;i++)
        {

            Vector3 vector3 = new Vector3(550 , 1500, 0);
            int cardNum = Random.Range(0, cardMessageList.Count-1);
            newCard.GetComponent<CardCreater>().cardMessage = cardMessageList[cardNum];
            GameObject A = Instantiate(newCard,vector3,Quaternion.identity,cardCanves);
            cards.Add(A);
            if (i <= 4)
            {
                A.transform.DOMove(new Vector3(520 + 250 * num, 800, 0), 1);
            }
            else
            {
                A.transform.DOMove(new Vector3(520 + 250 * (num%4), 500, 0), 1);
            }
            
            num++;
        }
    }

    public void Complite()
    {
        foreach (var card in cards)
        {
            card.transform.DOMove(new Vector3(550, 1500, 0), 1);
        }
    }

}
