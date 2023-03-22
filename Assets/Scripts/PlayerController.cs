using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torque = 1.0f;

    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            rigidBody.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            rigidBody.AddTorque(-torque);
        }
    }
}