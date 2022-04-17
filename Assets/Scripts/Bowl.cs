using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public GameObject ball;
    public float power;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 25;
    }   

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
            
        //}


        if (ball.transform.position.y < 0.4)
        {
            rb.AddForce(Vector3.forward * power);
            Debug.Log("Playyyy AUdiooo");
            AudioSource source = GetComponent<AudioSource>();
            Debug.Log(source);
            source.Play();
        }
    }
} 
