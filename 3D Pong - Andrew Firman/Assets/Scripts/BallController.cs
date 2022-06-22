using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    private Rigidbody rig;
    public Vector3 resetPosition;
    private Vector3 lastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

        lastVelocity = rig.velocity;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.GetComponent<Rigidbody>());
        Rigidbody CollisionRig = collision.gameObject.GetComponent<Rigidbody>();
        //Debug.Log(CollisionRig.velocity);
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

        rig.velocity = direction * Mathf.Max(speed, 2f);
        rig.velocity = rig.velocity + CollisionRig.velocity;
        
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
