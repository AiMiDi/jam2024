using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IncidentGrid : MonoBehaviour
{
    public Image[] RandomEventList;

    public Battle battle;
    // 事件
    void Start()
    {
        foreach (var window in RandomEventList)
        {
            window.gameObject.SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomOpen()
    {
        var window = RandomEventList[Random.Range(0, RandomEventList.Length)];
        window.transform.localPosition = Vector3.zero;
        window.gameObject.SetActive(true);
    }

    // 加金币
    public void addCoin(int coin)
    {
        battle.player.status.coin += coin;
    }

    // 扣金币


    // 

}
