using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Ahmad Fauzan Bagaskoro - 149251970101-165");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by ahmadfauzan96.");
    }
}
