using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScore : MonoBehaviour
{
    [Tooltip("how many points a hit on this object gets")]
    public int pointsPerHit = 1;

    private ScoreBoard scoreBoard;

    private void Start()
    {
        // get scoreboard object
        GameObject obj = GameObject.Find("scoreText");
        if (obj != null)
        {
            scoreBoard = obj.GetComponent<ScoreBoard>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if a ball collided with this it has a ballController
        if(collision.gameObject.GetComponent<BallController>() != null)
        {
            scoreBoard.gamescore += pointsPerHit;
        }
    }
}
