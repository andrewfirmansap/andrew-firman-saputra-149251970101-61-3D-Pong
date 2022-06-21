using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode leftKey;
    public KeyCode rightKey;
    public float speedModifier;
    private Rigidbody rig;
    public float min_x;
    public float max_x;


    //[SerializeField] private KeyCode downKey = KeyCode.S;
    //private Rigidbody2D rig;
    //public Collider2D ball;
    //public PowerUpManager manager;
    //private Vector3 tempScale;
    //private int magnitude;

    //private float speedTimer;
    //private float panjangTimer;
    //public float timeLimitSpeedup;
    //public float timeLimitPanjangup;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        //magnitude = 1;
        //tempScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        MoveObject(GetInput());

        //speedTimer += Time.deltaTime;
        //panjangTimer += Time.deltaTime;
        //if (speedTimer > timeLimitSpeedup)
        //{
        //    speedTimer = 0;
        //    magnitude = 1;
        //}
        //if (panjangTimer > timeLimitPanjangup)
        //{
        //    transform.localScale = new Vector3(tempScale.x, tempScale.y);
        //    panjangTimer = 0;
        //}

    }
    private Vector3 GetInput()
    {
        // get input

        if (Input.GetKey(leftKey) && transform.position.x > min_x)
        {
            return (Vector3.left * speedModifier);
        }
        else if (Input.GetKey(rightKey) && transform.position.x < max_x)
        {
            return (Vector3.right * speedModifier);
        }
        return Vector3.zero;

    }
    private void MoveObject(Vector3 movement)
    {
        rig.velocity = (movement);
        // Debug.Log("Paddle 1: "+movement);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision == ball)
    //    {
    //        //#ball.GetComponent<BallController>().ActivePUSpeedUp(magnitude);
    //        manager.PaddleP1Hit();
    //        //Debug.Log("paddle2 hit!");
    //    }
    //}
    //public void ActivePUSpeedUp()
    //{
    //    //Debug.Log("Speeding up!");
    //    magnitude = 2;
    //    speedTimer = 0;
    //}
    //public void ActivePUPanjangUp()
    //{
    //    panjangTimer = 0;
    //    Debug.Log("Panjang up!");
    //    tempScale = transform.localScale;
    //    transform.localScale = new Vector3(tempScale.x, 4f);
    //}
}
