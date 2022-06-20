using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElongateController : MonoBehaviour
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
                rightPaddle.GetComponent<PaddleController>().ActivateElongateRight(magnitude);
                manager.isELRight = true;
                manager.RemovePowerUp(gameObject);
            }
            else
            {
                leftPaddle.GetComponent<PaddleController>().ActivateElongateLeft(magnitude);
                manager.isELLeft = true;
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
