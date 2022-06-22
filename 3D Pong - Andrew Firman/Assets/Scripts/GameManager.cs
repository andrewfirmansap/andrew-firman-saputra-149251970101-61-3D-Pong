using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int maxBallAmount;
    public int spawnInterval;
    private float timer;
    public List<GameObject> ballTemplateList;
    private List<GameObject> ballList;
   
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (timer > spawnInterval)
        {
            SpawnRandomBall();
            timer -= spawnInterval;
        }

    }
    public void SpawnRandomBall()
    {
        if (ballList.Count >= maxBallAmount)
        {
            return;
        }
        else
        {
            int randomIndex = Random.Range(0, ballTemplateList.Count);
            GameObject ball = Instantiate(ballTemplateList[randomIndex], ballTemplateList[randomIndex].gameObject.transform.position, Quaternion.identity);
            ball.SetActive(true);
            ballList.Add(ball);
        }
        
    }
}
