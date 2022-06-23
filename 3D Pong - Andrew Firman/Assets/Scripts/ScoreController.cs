using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text P1_score;
    public Text P2_score;
    public Text P3_score;
    public Text P4_score;
    public Text GameOverText;
    public Text PlayerWonText;
    public ScoreManager manager;
    public GameManager gm;
    // Update is called once per frame
    void Update()
    {
        P1_score.text = manager.score_p1.ToString();
        P2_score.text = manager.score_p2.ToString();
        P3_score.text = manager.score_p3.ToString();
        P4_score.text = manager.score_p4.ToString();
        if (gm.isGameOver())
        {
            //Debug.Log("GAME OVER Score Controller");
            GameOverText.gameObject.SetActive(true);
            if(gm.isP1Dead() == false)
            {
                PlayerWonText.text = "P1 Won!";
            }
            if (gm.isP2Dead() == false)
            {
                PlayerWonText.text = "P2 Won!";
            }
            if (gm.isP3Dead() ==false)
            {
                PlayerWonText.text = "P3 Won!";
            }
            if (gm.isP4Dead() == false)
            {
                PlayerWonText.text = "P4 Won!";
            }
            PlayerWonText.gameObject.SetActive(true);
        }

    }
}