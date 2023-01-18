using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_checkpoint : MonoBehaviour
{
    public GameObject flag_pole;
    Vector3 spawnPoint;
    void Start()
    {
        spawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -20f)
        {
            gameObject.transform.position = spawnPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("flag_pole"))
        {
            spawnPoint = flag_pole.transform.position;
        }
    }




}
