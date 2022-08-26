using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce=10f;
    private float previousPosition=0;
    private float ballAcceleration=0;
    private float previousBallSpeed=0;
    private float ballSpeed=0;
    
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision collision)
    {
        
        rb.velocity = (Vector3.up * jumpForce);
        Debug.Log("Collosion Happened!!");
    }

    private void FixedUpdate()
    {
        ballSpeed = (transform.position.y - previousPosition )/ 0.1f;
        ballAcceleration = (previousBallSpeed - ballSpeed) / 0.1f;
        previousBallSpeed = ballSpeed;
        previousPosition = transform.position.y;

    }
}
