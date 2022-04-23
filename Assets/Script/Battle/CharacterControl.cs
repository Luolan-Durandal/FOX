using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    /*
    使用說明:
    在Main Player按+增加角色數量(主角和備用角色都要算進去)，按下Tab切換角色，
    iCharcaterCount為判斷switch裡的case的值，
    當iCharcaterCount=0執行case 0，iCharcaterCount=1執行case 1以此類推
*/
    public GameObject[] players;
    public float CD = 5;
    // 技能冷卻完畢提示
    // public GameObject remind;

    private int CharacterCount = 0;

    // Update is called once per frame
    void Update()
    {
        Count();
    }

    void Count()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            CharacterCount++;
            if(CharacterCount>=players.Length)
            {
                CharacterCount = 0;
            }
        }
        switch(CharacterCount)
        {
            case 0:
                {
                    players.GetValue(0); 
                    players[0].SetActive(true);
                    players[1].SetActive(false);
                    players[2].SetActive(false);
                }
                break;

            case 1:
                {
                    players.GetValue(1);
                    players[0].SetActive(false);
                    players[1].SetActive(true);
                    players[2].SetActive(false);
                }
                break;

            case 2:
                {
                    players.GetValue(2);
                    players[0].SetActive(false);
                    players[1].SetActive(false);
                    players[2].SetActive(true);
                }
                break;
        }
    }
    /* 技能cd
    void ColdDown()
    {
        if (CD <= 0)
        {
            CD -= Time.deltaTime;
            if ()
            {
                
            }
            else ()
            {
                remind.SetActive(true);
            }
        }
    }
    */



}
