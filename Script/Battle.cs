using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    [SerializeField] public Entity player;
    [SerializeField] public Entity enemy;
    [SerializeField] private GameObject background;

    [SerializeField] private GameObject[] monoEnemys;

    public EndlessParallaxBackground endlessParallaxBackground;

    // Start is called before the first frame update
    void Start()
    {
        endlessParallaxBackground = background.GetComponent<EndlessParallaxBackground>();

        player.attackedEntity = enemy;
        enemy.attackedEntity = player;
        player.battle = this;
        enemy.battle = this;

       endlessParallaxBackground.isBackgroundMove = false;


        player.BeginBattle();
        enemy.BeginBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
