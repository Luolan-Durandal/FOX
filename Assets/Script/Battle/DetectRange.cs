using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectRange : MonoBehaviour
{
    //  敵人衝向的目標
    public Transform target;
    //  敵人移動速度
    public int moveSpeed = 5;
    //  敵人旋轉速度
    public int rotationSpeed = 5;
    //  敵人和玩家之間的最大距離
    public int maxDistance;
    // ???  看下面解釋
    private Transform myTransform;
    
    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        //  通過標籤去查詢遊戲物件
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        //  將它的transform指定給target
        target = go.transform;
        maxDistance = 2;

    }

    void Update()
    {
        //  在敵人和玩家之間畫一條線
        Debug.DrawLine(target.position, myTransform.position, Color.red);
        //  看著目標
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);
        //  判斷敵人和玩家之間的距離是否大於最大距離
        if (Vector3.Distance(target.position, myTransform.position) > maxDistance)
        {
            //  移向目標
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
    }
}
