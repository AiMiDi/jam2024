using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectHandCard : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public bool flag=false;
    public bool isOnCard=false;
    public GameObject cardBox;
    public Vector3 position;
    public Quaternion rotation;
    public Vector3 scale;
    private Vector3 offset = new Vector3();
    private void Start()
    {
        cardBox = GameObject.Find("CardBox");
    }
    


    private void MouseOver()
    {
        if (!flag)
        {
            foreach (var card in cardBox.GetComponent<MyCards>().CardList)
            {
                card.GetComponent<SelectHandCard>().flag = false;
                card.GetComponent<SelectHandCard>().transform.DOMove(card.GetComponent<SelectHandCard>().position, 0.1f);
                card.GetComponent<SelectHandCard>().transform.DORotateQuaternion(card.GetComponent<SelectHandCard>().rotation, 0.1f);
                card.GetComponent<SelectHandCard>().transform.DOScale(card.GetComponent<SelectHandCard>().scale, 0.1f);                           
            }
        }
        flag = !flag;
        if (flag)
        {
            int dir = -1;
            foreach(var card in cardBox.GetComponent<MyCards>().CardList)
            {

                if (!card.GetComponent<SelectHandCard>().flag)
                {
                    card.transform.DOMove(new Vector3(
                        card.GetComponent<SelectHandCard>().position.x + dir * 80  , card.GetComponent<SelectHandCard>().position.y, card.GetComponent<SelectHandCard>().position.z), 0.5f);
                }
                else
                {
                    dir = 1;
                }
            }
            transform.DOMove(new Vector3(position.x-80, position.y + 100, position.z + 100), 0.5f);
            transform.DORotateQuaternion(Quaternion.Euler(0, 0, 0), 0.5f);
            transform.DOScale(new Vector3(0.7f, 0.7f, 0.7f), 0.5f);
        }
        else
        {
            foreach(var card in cardBox.GetComponent<MyCards>().CardList)
            {
                card.GetComponent<SelectHandCard>().transform.DOMove(card.GetComponent<SelectHandCard>().position, 0.5f);
                card.GetComponent<SelectHandCard>().transform.DORotateQuaternion(card.GetComponent<SelectHandCard>().rotation, 0.5f);
                card.GetComponent<SelectHandCard>().transform.DOScale(card.GetComponent<SelectHandCard>().scale, 0.5f);
            }
        }


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        offset = Input.mousePosition - transform.position;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition - offset; 
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if(transform.position.y >=600)
        {
            cardBox.GetComponent<MyCards>().CardList.Remove(gameObject);
            ReSetPosition();
            //��������Ч��
            Debug.Log("��������Ч��");
            Destroy(gameObject);
        }
    }

    public void ReSetPosition()
    {
        int maxNum = cardBox.GetComponent<MyCards>().CardList.Count;
        int num = 1;
        int p;
        foreach(var card in cardBox.GetComponent<MyCards>().CardList)
        {
            int dir;
            if (num < maxNum / 2 +1 && maxNum != 1)
            {
                card.transform.rotation = Quaternion.Euler(0, 0, (30 / (maxNum / 2) * (maxNum / 2 + 1 - num)));
                dir = -1;
            }
            else if ( (num == maxNum / 2 + 1 && maxNum % 2 != 0) || maxNum == 1)
            {
                card.transform.rotation = Quaternion.Euler(0, 0, 0);
                dir = 0;
            }
            else
            {
                card.transform.rotation = Quaternion.Euler(0, 0, -(30 / (maxNum / 2) * (num - maxNum / 2)));
                dir = 1;
            }
            if (maxNum % 2 == 1)
            {
                p = 1;
            }
            else
            {
                p = 0;
            }
            card.transform.DOMove(new Vector3(800 + dir * Mathf.Abs(maxNum / 2 + p - num) * 65, 150, 0), 1);
            card.GetComponent<SelectHandCard>().position = new Vector3(800 + dir * Mathf.Abs(maxNum / 2+p - num) * 65, 150, 0);
            card.GetComponent<SelectHandCard>().rotation = card.transform.rotation;
            card.GetComponent<SelectHandCard>().scale = new Vector3(0.5f, 0.5f, 0.5f);
            num++;
        }
    }
}
