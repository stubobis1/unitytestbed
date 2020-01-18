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

    public GameObject Ball;

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
                ResetMatch();
                
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
        if (playerScoredOn == 2)
        {
            Player2Score++;
        }
        GMStatus = Status.scored;
    }


    public void ResetMatch()
    {

        Player1ScoreText.text = "Score: " + Player1Score;
        Player2ScoreText.text = "Score: " + Player2Score;

        GMStatus = Status.playing;

        var ball = Instantiate(Ball);
        ball.GetComponent<plasmaPongBall>().GM = this;
    }

}
