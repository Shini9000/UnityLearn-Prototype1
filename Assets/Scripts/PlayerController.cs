using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

  private float speed = 10.0f;
  private float turnSpeed = 45.0f;
  private float horizontalInput;
  private float forwardInput;


  // Start is called before the first frame update
  void Start()
    {
        
    }

  // Update is called once per frame
  void Update()
  {
    // Input getter
    horizontalInput = Input.GetAxis("Horizontal");
    forwardInput = Input.GetAxis("Vertical");

    // Move the vehicle F/B
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
    // Rotate the vehicle L/R
    transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
  }
}
