using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleDeflection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            rb.velocity = rb.velocity * 1.1f;
        }
    }
}
