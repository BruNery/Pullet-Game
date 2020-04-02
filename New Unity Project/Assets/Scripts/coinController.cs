using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinController : MonoBehaviour
{

    public GameObject ginfo;
    public bool playerTouch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ginfo = GameObject.FindGameObjectWithTag("GameInfo");
        gameInfo GI = ginfo.GetComponent<gameInfo>();

        if (playerTouch == true)

        {
            Destroy(gameObject);
           GI.coins = GI.coins + 1;
            
        }

    }

     void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            playerTouch = true;
        }

        
    }
}
