using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackBehaviour : MonoBehaviour
{
    private EnemyMovementBehaviour _movement;

    private void Awake()
    {
        _movement = GetComponent<EnemyMovementBehaviour>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        //If the target isn't the target return
        if (collision.transform != _movement.Target)
            return;

        //Get a reference to the attached survival timer script
        SurvivalTimerBehaviour survivalTimer = collision.transform.GetComponent<SurvivalTimerBehaviour>();

        //If the timer isn't null, set game over
        if (survivalTimer)
            survivalTimer.SetGameOver();
    }
}
