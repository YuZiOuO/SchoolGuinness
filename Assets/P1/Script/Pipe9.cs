using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe9 : MonoBehaviour
{
	public Transform tf;
    void Start()
    {
        tf = this.GetComponent<Transform>();
        tf.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
    }


    private float OffsetX = 0;
    public float speed = 20f;
    int stage = 1;
    void FixedUpdate()
    {
        if (stage == 1)
        {
            if (Input.GetKey(KeyCode.Keypad3))
            {
                    OffsetX = Input.GetAxis("Mouse X");
                    tf.transform.Rotate(new Vector3(0, -OffsetX, 0) * speed);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                stage = 2;
            }
        }
    }

}
