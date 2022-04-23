using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CD : MonoBehaviour
{
    public float coldTime = 2; //冷卻時間
    private float timer = 0; //計時器
    private bool isStartTimer = false; //是否啟用計時
    public Image filledImage;
    public KeyCode keyCode; //施放按鍵
    public Text CDcount; //倒數文字
    void Start()
    {
        CDcount.enabled = false;
        filledImage.fillAmount = 0;
    }

      void Update()
    {
        if (Input.GetKeyDown(keyCode) && (Time.timeScale != 0))//按下按鍵 && 遊戲進行時
        {
            isStartTimer = true;
            CDcount.enabled = true; //啟用計時與倒數文字
        }
        
        if (isStartTimer)
        {
            timer += Time.deltaTime;
            filledImage.fillAmount = (coldTime - timer) / coldTime;
            CDcount.text = (coldTime - timer).ToString();
        }
        if (timer >= coldTime)
        {
            filledImage.fillAmount = 0;
            timer = 0;
            isStartTimer = false;
            CDcount.enabled = false; //停止計時與倒數文字    
        }
     
    }

}