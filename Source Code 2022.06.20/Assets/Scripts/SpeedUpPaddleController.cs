using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpPaddleController : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public BallController bola;
    public GameObject leftPaddle;
    public GameObject rightPaddle;
    public float magnitude;
    public bool isRight;
    public List<GameObject> powerUpTemplateList;

    private List<GameObject> powerUpList;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (bola.GetComponent<BallController>().isRight)
            {
                rightPaddle.GetComponent<PaddleController>().ActivateSpeedUpRight(magnitude);
                manager.isSURight = true;
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                leftPaddle.GetComponent<PaddleController>().ActivateSpeedUpLeft(magnitude);
                manager.isSULeft = true;
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
