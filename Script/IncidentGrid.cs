using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Progress;

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

    public void addCoin(int coin, int p)
    {
        if (Random.Range(0, 100) < p)
            battle.player.status.coin += coin;
    }

    // 1
    // 获得125猫猫币。
    public void add125Coin1()
    {
        battle.player.status.coin += 125;
    }
    // 获得75猫猫币。
    public void add75Coin1()
    {
        battle.player.status.coin += 75;
    }

    // 2
    // 选择损失25%生命获得随机的一张行动牌。
    public void Loss25LifeGainActionCard2()
    {
        battle.player.status.health -= battle.player.status.health / 4;
        // 获取行动牌
    }

    // 损失失50%生命获得一张道具牌。
    public void Loss50LifeGainItemCard2()
    {
        battle.player.status.health -= battle.player.status.health / 2;
        // 获取道具牌
    }

    public void PoisonBuff3()
    {
        battle.player.status.hasBuffs.Add(
            new Poison
            {
                poisonLayer = 3
            });
    }

    // 3
    // 获得行动牌，下次战斗会获得计数器为3的中毒。
    public void CardPoisonBuff3()
    {
        // 获取行动牌
        PoisonBuff3();
    }

    // 获得护甲牌，下次战斗会获得计数器为3的中毒。
    public void DefensePoisonBuff3()
    {
        // 获取护甲牌

        PoisonBuff3();
    }

    // 4
    // 获得金币。
    public void add50Coin4()
    {
        battle.player.status.coin += 50;
    }

    // 损失生命的护盾。
    public void LossLifeShield4()
    {
        battle.player.status.health -= battle.player.status.health / 4;
    }

    // 损失生命值。
    public void LossHPShield4()
    {
        battle.player.status.health -= battle.player.status.health / 8;
    }

    // 5 
    // 获得一张负面道具卡牌。
    public void GetItemCards5()
    {
        // 获取道具卡牌
    }

    // 恢复生命值。
    public void ReHPShield5()
    {
        battle.player.status.health += battle.player.status.health / 4;
    }

    // 随机获得行动牌。
    public void GetActionCards5()
    {
        // 获取行动卡牌

    }

    // 6
    // 攻击速度+0.2s。被隧道口撞下来了嘤嘤嘤。
    public void ExtraAttack6()
    {
        // 攻击速加0.2s

    }
    // 攻击速度+0.2s，获得道具和行动卡各一张。屁股好痛，但是拿到东西了喵！
    public void ExtraAttackAndGetCard6()
    {
        // 攻击速加0.2

        // 获取道具卡牌

        // 获取行动卡牌

    }

    // 7
    // 攻击速度+0.2s。车车大师，我悟了！
    public void ExtraAttack7()
    {
        // 攻击速加0.2s

    }

    // 失去一张行动卡。哇，好累啊……追不上……
    public void LossActionCard7()
    {
        // 失去一张卡牌

    }

    // 8
    // 攻击速度提升。
    public void ExtraAttack8()
    {
        // 攻击速加0.2s

    }
    // 下次战斗获得3层麻痹效果。
    public void CardPoisonBuff8()
    {
        // 行动牌
        PoisonBuff3();
    }
}
