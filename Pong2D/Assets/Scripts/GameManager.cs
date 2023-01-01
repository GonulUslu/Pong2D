using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;

    private int playerScore;
    private int computerScore;

    public void PlayerScores()
    {
        playerScore++;

        this.playerScoreText.text = playerScore.ToString();
        ResetRound();
    }
    public void ComputerScores()
    {
        computerScore++;

        this.computerScoreText.text = computerScore.ToString();
        ResetRound();


    }
    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
