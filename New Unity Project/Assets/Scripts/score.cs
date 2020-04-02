using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private Text CScore;
    public GameObject ginfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ginfo = GameObject.FindGameObjectWithTag("GameInfo");
        gameInfo GI = ginfo.GetComponent<gameInfo>();

        CScore = GetComponent<Text>();
        CScore.text = "" + GI.coins;

    }
}
