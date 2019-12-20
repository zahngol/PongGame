using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Goal : MonoBehaviour
{
    [SerializeField] private UnityEvent ScoreGoal = null;

    void OnTriggerEnter(Collider other)
    {
        ScoreGoal.Invoke();
    }
}
