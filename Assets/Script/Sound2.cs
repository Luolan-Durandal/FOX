using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sound2 : MonoBehaviour
{
    public Slider 背景音量拉桿;
    public Slider 效果音量拉桿;
    public AudioSource 背景音效;
    public AudioSource 效果音效;

    public void update()
    {
       
        背景音效.volume = 背景音量拉桿.value;
        效果音效.volume = 效果音量拉桿.value;
        
    }
}
