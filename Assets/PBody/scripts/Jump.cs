using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    private Rigidbody playerRb; 
   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb = AddForce(VEctor3.up * 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
