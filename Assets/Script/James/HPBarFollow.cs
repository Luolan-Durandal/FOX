using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBarFollow : MonoBehaviour
{
    // 生命值跟隨變數
    [SerializeField] Vector3 Enemy_HP; //生命值座標
    [SerializeField] Vector3 EnemyA_Position; //角色座標
    [SerializeField] GameObject HP_follow;
    private bool enemyalive = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(enemyalive)
        {
            // 生命值跟隨hpflw為生命值物件，mhp為生命值座標，mch為角色座標
            EnemyA_Position = transform.position;
            Enemy_HP = new Vector3(EnemyA_Position.x, EnemyA_Position.y + 10.0f, EnemyA_Position.z);
            HP_follow.transform.position = Enemy_HP;
        }
        
    }
}
