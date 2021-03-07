using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private Rigidbody rb;
    private int stage = 1;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stage <= 2)
        {
            P1();
        }
    }

    private float horizontalMove;
    void P1()
    {
        if (stage == 1)
        {
            horizontalMove = Input.GetAxis("Horizontal");
            if (rb.transform.position.x < 0 || rb.transform.position.x > 10)
            {
                rb.transform.position = new Vector3(5, 10, 14.5f);
            }
            else
            {
                rb.velocity = new Vector3(horizontalMove * speed, rb.velocity.y, rb.velocity.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stage = 2;
            rb.useGravity = true;
            rb.velocity = new Vector3(rb.velocity.x, -10, rb.velocity.z);
        }
    }
}
