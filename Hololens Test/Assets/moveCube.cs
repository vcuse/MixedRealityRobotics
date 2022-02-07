using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using communication;

public class moveCube : MonoBehaviour
{
    public UDPCommunication myserver;
    public GameObject cube;

    #if !UNITY_EDITOR

    // Start is called before the first frame update
    void Start()
    {
      
      //  string keyboardText = keybaord.text;
        string port = "6511";
        string controllerip = "192.168.0.7";
        myserver = new UDPCommunication(controllerip,port);
    }

    // Update is called once per frame
    void Update()
    {
        //positions of cube
        double cz = -cube.transform.position.z + .5 ; //initialize variables above
        double cx = cube.transform.position.x ;
        double cy = cube.transform.position.y ;  
        
        myserver.cubeMove(cx, cy, cz, cube.transform.eulerAngles.y - 180, cube.transform.eulerAngles.x + 
            60, cube.transform.eulerAngles.z - 180);

    }

    #else

    void Start()
    {}
    void Update()
    {}

    #endif
}
