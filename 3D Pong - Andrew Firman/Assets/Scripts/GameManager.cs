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
    public Material paddleDiedMaterial;
    private bool P1isDead;
    private bool P2isDead;
    private bool P3isDead;
    private bool P4isDead;
    private float timer;
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
    public void PaddleDied(int paddleNum)
    {
        if (paddleNum == 1)
        {
            paddle1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle1.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            Debug.Log("Paddle 1 died!");

        }
        else if (paddleNum == 2)
        {
            paddle2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle2.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            Debug.Log("Paddle 2 died!");

        }
        else if (paddleNum == 3)
        {
            paddle3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle3.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            Debug.Log("Paddle 3 died!");

        }
        else if (paddleNum == 4)
        {
            paddle4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            paddle4.GetComponent<MeshRenderer>().material = paddleDiedMaterial;
            Debug.Log("Paddle 4 died!");

        }
    }
}
