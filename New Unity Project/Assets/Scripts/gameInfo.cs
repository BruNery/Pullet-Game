using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameInfo : MonoBehaviour
{

    public int coins;
    public int life = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);


    }

}
