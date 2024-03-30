using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
  // Sets propeller speed
  //private float properllerSpinSpeed = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // Rotates properller at speed in var
    transform.Rotate(0, 0, 1);
        
    }
}
