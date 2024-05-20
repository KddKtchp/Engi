using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AutoJumpInTrigger : MonoBehaviour
{
    [SerializeField] UnityEvent onJumpOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("hurt player", this);
            SimplePlayerController pm = collision.transform.GetComponent<SimplePlayerController>();
            Rigidbody2D rb2DP = collision.transform.GetComponent<Rigidbody2D>();
            if(rb2DP.velocity.y < 0) { 
                pm.ForcedJump();
                onJumpOver.Invoke();
            }

        }
    }
}
