using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    [SerializeField] public Entity player;
    [SerializeField] public Entity enemy;

    // Start is called before the first frame update
    void Start()
    {
        player.attackedEntity = enemy;
        enemy.attackedEntity = player;

        player.BeginBattle();
        enemy.BeginBattle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
