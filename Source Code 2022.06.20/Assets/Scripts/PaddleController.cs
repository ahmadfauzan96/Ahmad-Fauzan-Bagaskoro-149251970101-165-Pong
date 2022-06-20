using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public float speed;
    public float magnitude;
    public KeyCode upKey;
    public KeyCode downKey;
    public Collider2D ball;
    public Collision2D collisionInfo;
    
    public BallController bola;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // mengambil input
        Vector2 movePaddle = GetInput();

        // menggerakkan objek dengan input
        MoveObject(movePaddle);
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            //gerakan ke atas
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            //gerakan ke bawah
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movePaddle)
    {
        rig.velocity = movePaddle;
    }

    // menambah kecepatan paddle
    public void ActivateSpeedUpLeft(float magnitude)
    {
        speed *= magnitude;
        Debug.Log(speed);
    }

    public void ActivateSpeedUpRight(float magnitude)
    {
        speed *= magnitude;
        Debug.Log(speed);
    }

    // memperpanjang paddle
    public void ActivateElongateLeft(float magnitude)
    {
        transform.localScale += new Vector3(0, 2, 0);
    }

    public void ActivateElongateRight(float magnitude)
    {
        transform.localScale += new Vector3(0, 2, 0);
    }

    // menghilangkan power up sebelumnya
    public void DeactivateSpeedUpLeft(float magnitude)
    {
        speed /= magnitude;
    }

    public void DeactivateSpeedUpRight(float magnitude)
    {
        speed /= magnitude;
    }

    public void DeactivateElongateLeft(float magnitude)
    {
        transform.localScale -= new Vector3(0, 2, 0);
    }

    public void DeactivateElongateRight(float magnitude)
    {
        transform.localScale -= new Vector3(0, 2, 0);
    }
}
