using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torque = 1.0f;
    [SerializeField] float baseSpeed = 20.0f;
    [SerializeField] float boostSpeed = 30.0f;

    Rigidbody2D rigidBody;
    SurfaceEffector2D effector;

    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        effector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
            rigidBody.AddTorque(torque);
        else if (Input.GetKey(KeyCode.RightArrow) == true)
            rigidBody.AddTorque(-torque);
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.Space) == true)
            effector.speed = boostSpeed;
        else
            effector.speed = baseSpeed;
    }

    public void DisableControls()
    {
        canMove = false;
    }
}