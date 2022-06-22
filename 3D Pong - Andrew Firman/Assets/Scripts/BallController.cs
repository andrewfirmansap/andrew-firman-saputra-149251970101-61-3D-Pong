using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody rig;
    public float resetPositionX;
    public float resetPositionY;
    public float resetPositionZ;
    private Vector3 resetPosition;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
        resetPosition = new Vector3(resetPositionX, resetPositionY, resetPositionZ);
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void ResetBall()
    {
        transform.position = resetPosition;
        rig.velocity = -rig.velocity;
    }
    public void ActivePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }
}
