using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement_player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed_movement = 50f;

    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, speed_movement * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -speed_movement * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-speed_movement * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(speed_movement * Time.deltaTime, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Star"))
        {
            other.gameObject.SetActive(false);
        }

        

        else if (other.gameObject.CompareTag("checkpoint_ring"))
        {
            other.gameObject.SetActive(false);
        }

    }

    



}


