using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
    private new Rigidbody rigidbody;

    private void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void ResetBallPosition()
    {
        rigidbody.velocity = Vector3.zero;
        transform.position = Vector3.zero;
        StartCoroutine(StartMovement());
    }

    private IEnumerator StartMovement()
    {
        yield return new WaitForSeconds(2f);
        rigidbody.velocity = Vector3.right * 5;
    }
}
