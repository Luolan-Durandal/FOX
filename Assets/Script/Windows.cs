using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windows : MonoBehaviour
{
    public GameObject 音量;
    public GameObject 故事;
    public GameObject 結束遊戲;
    public GameObject 音量設置;
    public GameObject 故事簡介;
    public GameObject 返回遊戲;
   public void Sound() //調整音量視窗
    {
        音量.SetActive(true);
    }
    public void CloseSound() //關閉視窗
    {
        音量.SetActive(false);   
    }
    public void Story() //故事簡介
    {
        故事.SetActive(true);
       // 結束遊戲.SetActive(false);
    }
    public void CloseStory() //關閉視窗
    {
        故事.SetActive(false);
        結束遊戲.SetActive(true);
    }
    public void Menu()
    {
        返回遊戲.SetActive(true);
        音量設置.SetActive(true);
       // 故事簡介.SetActive(true);
        結束遊戲.SetActive(true);
          Time.timeScale = 0;
    }
    public void back() //返回遊戲
    {
        返回遊戲.SetActive(false);
        音量設置.SetActive(false);
      //  故事簡介.SetActive(false);
        結束遊戲.SetActive(false);
        音量.SetActive(false);
        Time.timeScale = 1f;
    }
}
