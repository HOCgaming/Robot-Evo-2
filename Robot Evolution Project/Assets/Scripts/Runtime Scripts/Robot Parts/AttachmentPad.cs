using UnityEngine;
using System.Collections;

public class AttachmentPad : MonoBehaviour {

    /* Parent to each part of the robot.
     * Handles the connection of parts, and their orientation.
     */
     
    private GameObject myPart;
    private PartClass myPartClass;
    
	void Start () {

        //Get references to this pad's part.
        myPart = gameObject.GetComponentInChildren<PartClass>().gameObject;
        myPartClass = gameObject.GetComponentInChildren<PartClass>();
	
	}
	
	void Update () {
	
	}
}
