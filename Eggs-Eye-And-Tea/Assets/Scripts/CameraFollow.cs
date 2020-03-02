using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //Camera Follows
    public Transform target; //target is player
    public float offset;     //general offset the camera is at from the player
    public float Yoffset;    //offset the camera is at from the player on the Y axis (height so it doesnt show floor)

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = (Screen.height / offset);
        //changes height depending on the height of each person's screen
    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y - Yoffset, transform.position.z);
        //because im messy and this is the only way i was able to do things, i will have to change the value of the variables Yoffset and offset
        //once i add in the characters and the backgrounds. or else it will mess it up as i only made this to fit with the square prototype
    }
}
