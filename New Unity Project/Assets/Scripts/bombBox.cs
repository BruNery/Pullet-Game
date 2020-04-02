using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombBox : MonoBehaviour
{
    public GameObject Explosion;
    private bool BoxExplosion;
    private SpriteRenderer box;


    private CharacterController2D player;
    // Start is called before the first frame update
    void Start()
    {
        Explosion.SetActive(false);
        box = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BoxExplosion == true)
        {
            Explosion.SetActive(true);
            box.enabled = false;
            Destroy(this.gameObject, 1f);
            //TakeDamage(1);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            BoxExplosion = true;
            player.TakeDamage(1);

        }

      
    }
}
