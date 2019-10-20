using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Update()
    {
        // Check reset button
        if(Input.GetKey(KeyCode.R))
        {

        }
    }

    private void ResetGame()
    {
        // get scoreboard object
        ScoreBoard scoreBoard;
        GameObject obj = GameObject.Find("scoreText");
        if (obj != null)
        {
            scoreBoard = obj.GetComponent<ScoreBoard>();
            scoreBoard.gamescore = 0;
        }
        DestroyBall destroyBall = GameObject.FindGameObjectWithTag("GameController").GetComponent<DestroyBall>();
        destroyBall.ResetBall();
    }
}
