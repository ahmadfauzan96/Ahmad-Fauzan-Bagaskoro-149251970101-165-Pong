using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;

    public int maxScore;

    public BallController ball;

    // Tambah skor bagi kubu kanan
    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();
        if (rightScore >= maxScore)
        {
            GameOver();
        }
    }

    // Tambah skor bagi kubu kiri
    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBall();
        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    // Permainan berakhir jika salah satu kubu mencapai skor maksimum tertentu
    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
