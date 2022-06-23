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
            GameOverText.enabled = true;
            if(!gm.isP1Dead())
            {
                PlayerWonText.text = "P1 Won!";
            }
            if (!gm.isP2Dead())
            {
                PlayerWonText.text = "P2 Won!";
            }
            if (!gm.isP3Dead())
            {
                PlayerWonText.text = "P3 Won!";
            }
            if (!gm.isP4Dead())
            {
                PlayerWonText.text = "P4 Won!";
            }
        }

    }
}