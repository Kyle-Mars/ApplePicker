using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class AppleTreeScript : MonoBehaviour
{
    public GameObject Apple;

    public float appleDropTime = 1.0f;
    public float speed = 10.0f;
    public float percentChangeDirection = 0.1f;
    public float edgeDistance = 13f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", appleDropTime);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(Apple);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropTime);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if(pos.x < -edgeDistance && speed < 0 || pos.x > edgeDistance && speed > 0)
        {
            speed *= -1f;
        }
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        if (-edgeDistance <= pos.x && edgeDistance >= pos.x && UnityEngine.Random.value < percentChangeDirection)
        {
            speed *= -1;
        }
    }
}
