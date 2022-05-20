using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    public bool toRight;
    public float speed;
    public GameObject sphere;
    public GameObject cylinder;
    public GameObject ColumnaI;
    public GameObject ColumnaD;
    
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight){
            transform.position += new Vector3(speed,0,0);
        } else {
            transform.position += new Vector3(-speed,0,0);
        }

        if (transform.position.x > ColumnaI.transform.position.x-1){
            toRight = false;
            Instantiate(sphere);
            sphere.transform.position = new Vector3(ColumnaI.transform.position.x,2,0);
            

        } else if (transform.position.x < ColumnaD.transform.position.x+1){
            toRight = true;
            Instantiate(cylinder);
            cylinder.transform.position = new Vector3(ColumnaD.transform.position.x,2,0);
            
        }
        
    }
}
