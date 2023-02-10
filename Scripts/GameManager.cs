// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using Tobii.Gaming;

// public class GameManager : MonoBehaviour
// {
//     public static GameManager instance;

//     public GameObject livesHolder;

//     int score = 0;

//     int lives = 3;

//     bool gameOver = false;

//     public Text scoreText;

//     private void Awake()
//     {
//         instance = this;
//     }

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (!gameOver)
//         {
//             CheckForEyeTrackingInput();
//         }
//     }

//     private void CheckForEyeTrackingInput()
//     {
//         var gazePoint = TobiiAPI.GetGazePoint();
        
//         if (gazePoint.IsRecent() && gazePoint.IsValid)
//         {
//             // Check if the gaze point is within a specific area on the screen to increment score
//             if (gazePoint.Screen.x >= 0.5f && gazePoint.Screen.x <= 1f && gazePoint.Screen.y >= 0.5f && gazePoint.Screen.y <= 1f)
//             {
//                 IncrementScore();
//             }

//             // Check if the gaze point is within a specific area on the screen to decrease life
//             if (gazePoint.Screen.x >= 0f && gazePoint.Screen.x <= 0.5f && gazePoint.Screen.y >= 0f && gazePoint.Screen.y <= 0.5f)
//             {
//                 DecreaseLife();
//             }
//         }
//     }

//     public void IncrementScore()
//     {
//         score++;

//         scoreText.text = score.ToString();
//     }

//     public void DecreaseLife()
//     {
//         if(lives > 0){
//             lives--;

//             print(lives);

//             livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
//         }

//         if(lives <= 0)
//         {
//             gameOver = true;

//             GameOver();
//         }
//     }

//     public void GameOver()
//     {
//         CandySpawner.instance.StopSpawningCandies();

//         GameObject.Find("player").GetComponent<PlayerController>().canMove = false;

//         print("GameOver()");
//     }
// }









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
