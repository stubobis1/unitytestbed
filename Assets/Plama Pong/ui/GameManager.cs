using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;

    public int maxscore;

    public Text Player1ScoreText;
    public Text Player2ScoreText;

    int Player1Score;
    int Player2Score;


    public enum Status {
        start,
        playing,
        scored,
    }

    public Status GMStatus = Status.start;
    void Start()
    {
        print(Player1ScoreText.GetComponent<Text>());
        Application.targetFrameRate = 300;
    }


    void Update()
    {
        switch (GMStatus)
        {
            case Status.start:
            
            case Status.scored:

                GMStatus = Status.playing;
                break;
            case Status.playing:
            default:
                break;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="playerScoredOn">NOT 0-based</param>
    public void Score(int playerScoredOn)
    {
        if (playerScoredOn == 1)
        {
            Player1Score++;
        }
        
    }

}
