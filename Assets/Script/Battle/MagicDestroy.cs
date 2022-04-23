using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3f);
    }

    // 碰到敵人時，敵人生命-10 待解決:碰到敵人，但敵人生命值未減少
    private void OnTriggerEnter2D(Collider2D enm)
    {
        if (enm.gameObject.tag == "Enemy")
        {
            Panel.EnemyCurrentHp -= 10;
        }
    }
}
