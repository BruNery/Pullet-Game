using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{

    private CharacterController2D player;
    // Start is called before the first frame update
    void Start() => player = GameObject.FindWithTag("Player").GetComponent<CharacterController2D>();
    //hfghfvxdfgchg
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.TakeDamage(1);

            Coroutine coroutine = StartCoroutine(player.KnockBack(0.02f, 350, player.transform.position));
        }
    }
}
