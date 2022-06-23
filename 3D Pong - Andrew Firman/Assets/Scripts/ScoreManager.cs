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
    public GameManager gm;
    public void AddScore(string p_side, int increment)
    {
        if (p_side == "p1")
        {
            if (score_p1 >= maxScore)
            {
                return;
            }
            else
            {
                score_p1 += increment;
            }
            if (score_p1 >= 15)
            {
                gm.PaddleDied(1);
            }
        }
        else if (p_side == "p2")
        {
            if (score_p2 >= maxScore)
            {
                return;
            }
            else
            {
                score_p2 += increment;
            }
            if (score_p2 >= 15)
            {
                gm.PaddleDied(2);
            }
        }
        else if (p_side == "p3")
        {
            if (score_p3 >= maxScore)
            {
                return;
            }
            else
            {
                score_p3 += increment;
            }
            if (score_p3 >= 15)
            {
                gm.PaddleDied(3);
            }
        }
        else if (p_side == "p4")
        {
            if (score_p4 >= maxScore)
            {
                return;
            }
            else
            {
                score_p4 += increment;
            }
            if (score_p4 >= 15)
            {
                gm.PaddleDied(4);
            }
        }
        
        
       
        
        //ballcontroller.ResetBall();



    }
    //public void GameOver()
    //{
    //    SceneManager.LoadScene("Main Menu");
    //}
}
