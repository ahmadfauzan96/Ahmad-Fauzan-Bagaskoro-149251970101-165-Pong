using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Ahmad Fauzan Bagaskoro - 149251970101-165");
    }
}
