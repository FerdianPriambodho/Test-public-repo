using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinPanel : MonoBehaviour
{
    public GameObject winScore;
    void Start()
    {
        winScore.GetComponent<Text>().text = PlayerPrefs.GetInt("scoreOnLevel").ToString();
        //Debug.Log(PlayerPrefs.GetInt("totalScore"));
    }

    public void onNextButtonClicked()
    {
        if (SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings-1)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else onMenuButtonClicked();
    }
    public void onRestartButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void onMenuButtonClicked()
    {
        SceneManager.LoadScene(0);
    }
}
