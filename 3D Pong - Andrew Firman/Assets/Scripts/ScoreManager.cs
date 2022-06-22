using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score_p1, score_p2, score_p3, score_p4;
    public int maxScore = 15;
    public BallController ballcontroller;
    public void AddScore(string p_side, int increment)
    {
        if (p_side == "p1")
        {
            score_p1 += increment;
        }
        else if (p_side == "p2")
        {
            score_p2 += increment;
        }
        else if (p_side == "p3")
        {
            score_p3 += increment;
        }
        else if (p_side == "p4")
        {
            score_p4 += increment;
        }
        //ballcontroller.ResetBall();
        //if (score_p1 >= maxScore || score_p2 >= maxScore)
        //{
        //    GameOver();
        //}


    }
    //public void GameOver()
    //{
    //    SceneManager.LoadScene("Main Menu");
    //}
}
