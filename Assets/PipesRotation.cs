using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesRotation : MonoBehaviour
{
	public Transform tf1;
    public Transform tf2;
    public Transform tf3;
    public Transform tf4;
    public Transform tf5;
    public Transform tf6;
    public Transform tf7;
    public Transform tf8;
    public Transform tf9;
    void Start()
    {
        tf1.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf2.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf3.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf4.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf5.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf6.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf7.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf8.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
        tf9.transform.Rotate(new Vector3(0, Random.Range(-40.0f, 40.0f), 0));
    }


    private float OffsetX = 0;
    private float OffsetY = 0;
    public float speed = 1;
    int stage = 1;
    void FixedUpdate()
    {
        if (stage == 1)
        {
            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf1.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf2.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf3.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf4.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf5.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf6.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf7.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf8.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                if (Input.GetMouseButton(0))
                {
                    OffsetX = Input.GetAxis("Mouse X");//获取鼠标x轴的偏移量
                    OffsetY = Input.GetAxis("Mouse Y");//获取鼠标y轴的偏移量

                    tf9.transform.Rotate(new Vector3(OffsetY, -OffsetX, 0) * speed);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            stage = 2;
        }
    }

}
