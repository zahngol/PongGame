using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 direction;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = direction * speed;
    }
}
