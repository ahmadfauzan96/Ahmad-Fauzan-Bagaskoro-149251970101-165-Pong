using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxPowerUp;
    public int spawnInterval;
    public GameObject leftPaddle;
    public GameObject rightPaddle;
    public bool isSULeft, isSURight, isELLeft, isELRight;
    public float magnitude;

    public BallController bola;
    
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;
    public List<GameObject> powerUpTemplateList;

    private List<GameObject> powerUpList;
    
    private float timer;
    private float timerSULeft, timerSURight, timerELLeft, timerELRight;

    private void Start()
    {
        powerUpList = new List<GameObject>();
        timer = 0;
    }

    //Timer
    private void Update()
    {
        timer += Time.deltaTime;

        //Timer Game
        if (timer > spawnInterval)
        {
            if (powerUpList.Count == maxPowerUp)
            {
                RemoveAllPowerUp();
            }
            GenerateRandomPowerUp();
            timer -= spawnInterval;
        }
        //Timer Speed Up paddle kanan
        if (isSURight)
        {
            if (timerSURight > spawnInterval)
            {
                rightPaddle.GetComponent<PaddleController>().DeactivateSpeedUpRight(magnitude);
                isSURight = false;
                timerSURight -= spawnInterval;
            }
            timerSURight += Time.deltaTime;
        }
        //Timer Speed Up paddle kiri
        if (isSULeft)
        {
            if (timerSULeft > spawnInterval)
            {
                leftPaddle.GetComponent<PaddleController>().DeactivateSpeedUpLeft(magnitude);
                isSULeft = false;
                timerSULeft -= spawnInterval;
            }
            timerSULeft += Time.deltaTime;
        }
        //Timer Elongate paddle kanan
        if (isELRight)
        {
            if (timerELRight > spawnInterval)
            {
                rightPaddle.GetComponent<PaddleController>().DeactivateElongateRight(magnitude);
                isELRight = false;
                timerELRight -= spawnInterval;
            }
            timerELRight += Time.deltaTime;
        }
        //Timer Elongate paddle kiri
        if (isELLeft)
        {
            if (timerELLeft > spawnInterval)
            {
                leftPaddle.GetComponent<PaddleController>().DeactivateElongateLeft(magnitude);
                isELLeft = false;
                timerELLeft -= spawnInterval;
            }
            timerELLeft += Time.deltaTime;
        }
    }

    //Menghasilkan power up secara random
    public void GenerateRandomPowerUp()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));
    }

    public void GenerateRandomPowerUp(Vector2 position)
    {
        if (powerUpList.Count >= maxPowerUp)
        {
            return;
        }

        if (position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        powerUpList.Add(powerUp);
    }

    //Menghapus power up
    public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }
}
