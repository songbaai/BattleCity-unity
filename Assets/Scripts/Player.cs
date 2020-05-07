using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");//left -1 right 1
        transform.Translate(Vector3.right * h * moveSpeed * Time.deltaTime, Space.World);
        

        float v = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.up * v * moveSpeed * Time.deltaTime, Space.World);
    }
}
