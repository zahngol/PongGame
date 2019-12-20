using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Vector2 direction = Vector2.right;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = direction * speed;
    }
}
