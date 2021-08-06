using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(30,120),0);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*500);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)){
            transform.eulerAngles = new Vector3(0,Random.Range(60,120),0);
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*1);
        }else if(Input.GetKey(KeyCode.Space)){
            transform.eulerAngles = new Vector3(Random.Range(60,120),0,0);
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*1);
        }else if(Input.GetKey(KeyCode.Tab)){
            transform.eulerAngles = new Vector3(0, 80,Random.Range(60,120));
            gameObject.GetComponent<Rigidbody>().AddForce(transform.forward*1);
        }
    }
}
