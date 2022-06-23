using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int maxBallAmount;
    public int spawnInterval;
    public GameObject paddle1;
    public GameObject paddle2;
    public GameObject paddle3;
    public GameObject paddle4;
    public GameObject GoalP1;
    public GameObject GoalP2;
    public GameObject GoalP3;
    public GameObject GoalP4;
    public Material paddleDiedMaterial;
    private bool P1isDead;
    private bool P2isDead;
    private bool P3isDead;
    private bool P4isDead;
    private float timer;
    private int deathCount;
    public List<GameObject> ballTemplateList;
    private List<GameObject> ballList;
   
    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<GameObject>();
        P1isDead = false;
        P2isDead = false;
        P3isDead = false;
        P4isDead = false;
        deathCount=0;
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

        if (deathCount == 3)
        {
            Debug.Log("Game Over");
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
    public void PaddleDied(int paddleNum)
    {
        if (paddleNum == 1)
        {
            paddle1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle1.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            GoalP1.GetComponent<Collider>().isTrigger= false;
            P1isDead = true;
            Debug.Log("Paddle 1 died!");
            deathCount = deathCount + 1;

        }
        else if (paddleNum == 2)
        {
            paddle2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle2.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            GoalP2.GetComponent<Collider>().isTrigger = false;
            P2isDead = true;
            Debug.Log("Paddle 2 died!");
            deathCount = deathCount + 1;

        }
        else if (paddleNum == 3)
        {
            paddle3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle3.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            GoalP3.GetComponent<Collider>().isTrigger = false;
            P3isDead = true;
            Debug.Log("Paddle 3 died!");
            deathCount = deathCount + 1;

        }
        else if (paddleNum == 4)
        {
            paddle4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle4.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            GoalP4.GetComponent<Collider>().isTrigger = false;
            P4isDead = true;
            Debug.Log("Paddle 4 died!");
            deathCount = deathCount + 1;

        }
    }
}
