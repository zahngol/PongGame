using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.zahngol.pong
{
    public class PaddleMovement : MonoBehaviour
    {
        [SerializeField] private KeyCode upKey;
        [SerializeField] private KeyCode downKey;
        [SerializeField] [Range(0,0.5f)] private float speed = 0.25f;

        void Update()
        {
            if (Input.GetKey(upKey))
            {
                transform.Translate(0,speed,0);
            }
            if (Input.GetKey(downKey))
            {
                transform.Translate(0,-speed,0);
            }
        }
    }
}
