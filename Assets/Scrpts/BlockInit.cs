using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInit : MonoBehaviour
{
    
    public GameObject blockObjPrefab;
    public GameObject blockesObj;
    
    void Awake(){
        for(int x = 0; x < 8; x++){
            GameObject masterObj = GameObject.Find("Master");
            for(int y = 0; y< 5; y++){
                GameObject g = Instantiate(blockObjPrefab, blockesObj.transform);
                g.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f+(1.2f*x)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
    }
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
