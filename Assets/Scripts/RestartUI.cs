using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartUI : MonoBehaviour
{


    public Canvas restartGame;



    void Start()
    {
        restartGame = GetComponent<Canvas>();


        gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
