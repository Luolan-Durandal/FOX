using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour
{

    // 對話框跟隨人物
    [SerializeField] Vector3 dialog;
    [SerializeField] Vector3 Npc;
    [SerializeField] GameObject dialogbox;
    [SerializeField] float height;
    private bool talk = true;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(talk)
        {
            Npc=transform.position; // 抓取人物位置
            dialog = new Vector3(Npc.x, Npc.y + height, Npc.z);
            dialogbox.transform.position = dialog;
        }
        
    }
}
