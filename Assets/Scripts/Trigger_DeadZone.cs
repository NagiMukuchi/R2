using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
            GameManager.instance.GameEnded();
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.collider.GetComponent<Player>() != null)
    //        GameManager.instance.GameEnded();

    //}
}
