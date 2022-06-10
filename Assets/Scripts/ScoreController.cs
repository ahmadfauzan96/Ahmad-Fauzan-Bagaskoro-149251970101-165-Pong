using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreKanan;
    public Text scoreKiri;

    public ScoreManager manager;

    private void Update()
    {
        scoreKanan.text = manager.rightScore.ToString();
        scoreKiri.text = manager.leftScore.ToString();
    }
}
