using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetrunGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene("Main");
        }else if(Input.GetKey(KeyCode.Return)){
            SceneManager.LoadScene("Title");
        }
    }
}
