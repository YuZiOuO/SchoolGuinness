using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomCubePosition : MonoBehaviour
{
    public Rigidbody rb;
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1.0f, 9.0f);
        rb.transform.position = new Vector3(x, rb.transform.position.y, rb.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
