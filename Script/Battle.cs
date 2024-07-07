using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    [SerializeField] public Entity player;
    [SerializeField] public Entity enemy;
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject ground;

    [SerializeField] private GameObject[] monoEnemys;

    public EndlessParallaxBackground endlessParallaxBackground;

    private bool eventLock = false;

    // Start is called before the first frame update
    void Start()
    {
        endlessParallaxBackground = background.GetComponent<EndlessParallaxBackground>();
        player.battle = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(eventLock)
            return;

        NextEvent();
    }

    void addMonoEnemy()
    {
        var enemy = Instantiate(monoEnemys[Random.Range(0, monoEnemys.Length)]);
       
        enemy.GetComponent<Enemy>().attackedEntity = player;
        player.attackedEntity = enemy.GetComponent<Enemy>();
        enemy.GetComponent<Enemy>().battle = this;
        enemy.GetComponent<Enemy>().BeginBattle();
    }

    void addBossEnemy()
    {
        var enemy = Instantiate(monoEnemys[Random.Range(0, monoEnemys.Length)]);

        enemy.GetComponent<Enemy>().attackedEntity = player;
        player.attackedEntity = enemy.GetComponent<Enemy>();
        enemy.GetComponent<Enemy>().battle = this;
        enemy.GetComponent<Enemy>().BeginBattle();
    }

    void BeginBattle()
    {
        eventLock = true;
        if (Random.Range(0, 100) < 70)
        {
            addMonoEnemy();
        }
        else
        {
            addBossEnemy();
        }
    }

    public void EndBattle(bool isPlayerDead)
    {
        if (!isPlayerDead)
        {
            eventLock = false;
        }
        else
        {
            GameOver();
        }
        
    }

    void BeginEvent()
    {
        eventLock = true;
    }

    void EndEvent()
    {
        eventLock = false;
    }

    void NextEvent()
    {
        var random = Random.Range(0, 100);

        if (random < 50)
        {
            BeginBattle();
        }
        else if (random < 70)
        {
            
        }
        else
        {
            
        }
    }

    void GameOver()
    {

    }
}
