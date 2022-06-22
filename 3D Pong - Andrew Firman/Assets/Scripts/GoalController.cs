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
    //public ScoreManager manager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision == ball)
        {
            Debug.Log("Ball collided.");
        }
    }
}
