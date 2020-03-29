using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResolution : MonoBehaviour
{
    public bool maintainWidth = true;
    [Range(-1,1)]
    public int adaptPosition;
    float defaultWidth;
    float defaultHeight;
    Vector3 CameraPose;
    void Start()
    {
        CameraPose = Camera.main.transform.position;
        defaultHeight = Camera.main.orthographicSize;
    //    defaultWidth = Camera.main.orthographicSize * CameraPose.main.aspect;
    }

    void Update()
    {
        if(maintainWidth)
        {
    //        Camera.main.orthographicSize = defaultWidth / CameraPose.main.aspect;
            Camera.main.transform.position = new Vector3(CameraPose.x, adaptPosition * (defaultHeight - Camera.main.orthographicSize), CameraPose.z);
        }
        else 
        {
   //         Camera.main.transform.position = new Vector3(adaptPosition * (defaultWidth-Camera.main.orthographicSize*CameraPose.main.aspect),CameraPose.y,CameraPose.z);
        }
    }
}
