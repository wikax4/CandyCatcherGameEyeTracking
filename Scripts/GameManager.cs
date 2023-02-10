using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject livesHolder;

    int score = 0;

    int lives = 3;

    bool gameOver = false;

    public Text scoreText;

    private void Awake()
    {
            instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {

            score++;

            scoreText.text = score.ToString();
        }

       // print(score);
    }

    public void DecreaseLife()
    {
        if(lives > 0){
            lives--;

            print(lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }

        if(lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }

    public void GameOver()
    {

        CandySpawner.instance.StopSpawningCandies();

        GameObject.Find("player").GetComponent<PlayerController>().canMove = false;

        print("GameOver()");
    }
}
