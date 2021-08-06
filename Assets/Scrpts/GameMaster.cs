using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int blockNum;
    public float nowTime;

    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        if(blockNum <= 0){
            GameFinish("You clear the game.\n Time is "+nowTime.ToString("F0")+"s!");
        }
    }
    public void GameFinish(string resultMessage){
        DataSender.resultMessage = resultMessage;
        SceneManager.LoadScene("Result");
    }
}
