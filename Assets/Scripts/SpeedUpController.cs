using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpController : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivateSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
