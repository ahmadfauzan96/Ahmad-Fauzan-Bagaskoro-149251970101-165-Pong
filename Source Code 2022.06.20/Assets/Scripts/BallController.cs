using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    public string lastCollision;

    public PowerUpManager manager;
    public SpeedUpPaddleController speedUp;
    public ElongateController elongate;

    public bool isRight;
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Meletakkan bola pada posisi awal setelah masuk salah satu gawang
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }

    // Menambah kecepatan bola
    public void ActivateSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
        Debug.Log(speed);
    }

    // Memeriksa paddle terakhir yang ditabrak oleh bola
    public void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        lastCollision = collisionInfo.collider.tag;
        if (lastCollision == "PaddleKanan")
        {
            isRight = true;
        }
        else
        {
            isRight = false;
        }
    }
}
