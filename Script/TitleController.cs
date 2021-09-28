using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public Text hightScoreText;

    public void Start()
    {
        //ハイスコアを表示
        hightScoreText.text = "High Score : " + PlayerPrefs.GetInt("HighScore") + "m";
    }


    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Main");
    }
}
