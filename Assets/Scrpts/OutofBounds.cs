using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision){
        int num = 40 - GameObject.Find("Master").GetComponent<GameMaster>().blockNum;
        GameObject.Find("Master").GetComponent<GameMaster>().GameFinish("You failed the game.\nBroken blocks : " + num.ToString());
    }
}
