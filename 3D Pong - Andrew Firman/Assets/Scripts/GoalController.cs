using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool isP1;
    public bool isP2;
    public bool isP3;
    public bool isP4;

    public ScoreManager manager;
    public GameManager gm;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "BallBL(Clone)" || collision.gameObject.name == "BallBR(Clone)" || collision.gameObject.name == "BallTR(Clone)" || collision.gameObject.name == "BallTL(Clone)")
        {
            //Debug.Log("Ball collided.");
            gm.RemoveBall(collision.gameObject);
            if (isP1)
            {
                manager.AddScore("p1", 1);
            }
            else if (isP2)
            {
                manager.AddScore("p2", 1);
            }
            else if (isP3)
            {
                manager.AddScore("p3", 1);
            }
            else if (isP4)
            {
                manager.AddScore("p4", 1);
            }
        }
    }
}
