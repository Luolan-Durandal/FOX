using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CameraFollow : MonoBehaviour
{

    public static CameraFollow CameraInstance;

    // 對話框彈出
    [SerializeField] GameObject dialogbox;
    [SerializeField] Flowchart flowchart;
    string getweapon = "獲得小太刀";

    // 目標物，背景，中景
    public Transform target, background, midground;

    public float MinHeight, MaxHeight;

    private bool CameraKeepFollow = true;

    [SerializeField] private Vector3 LastPosition;

    // Update is called once per frame

    void Awake()
    {

        CameraInstance = this;
    }

    void Start()
    {
        LastPosition = transform.position;
        
    }

    void FixedUpdate()
    {
        if (CameraKeepFollow) // 攝影機會跟隨玩家移動，中後景會跟著攝影機移動，!代表否定
        {
            // mathf.clamp 限制物體在一定範圍內移動，target.position.y代表物體y軸，MinHeight, MaxHeight為物體position y軸最大值和最小值
            transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, MinHeight, MaxHeight), transform.position.z);
            /* 中後景會跟著攝影機位置移動，可以不用貼一大片背景，等中景畫好再開啟
            Vector3 AmounToMove = new Vector3(transform.position.x - LastPosition.x, transform.position.y - LastPosition.y);

            background.position = background.position + new Vector3(AmounToMove.x, AmounToMove.y, 0f);
            midground.position += new Vector3(AmounToMove.x, AmounToMove.y, 0f);
            */
            LastPosition = transform.position;
        }

        if (dialogjump == true)
        {
            // 對話框位置在攝影機前方
            float a = transform.position.x;
            float b = transform.position.y;
            float c = transform.position.z;
            dialogbox.transform.position = new Vector3(a, b, c + 30);
        }
    }

    private bool dialogjump
    {
        get
        {
            return flowchart.GetBooleanVariable(getweapon);
        }
    }

}

