using UnityEngine;
using System.Collections;

public class AttachmentPad : MonoBehaviour {
    private bool debug = true;

    /* Parent to each part of the robot.
     * Handles the connection of parts, and their orientation.
     */
     
    [SerializeField] private GameObject myPart;
    private PartClass myPartClass;
    private Vector3 padToCentre;
    private bool inUse;
    
	void Start () {

        //Get references to this pad's part.
        myPart = gameObject.GetComponentInParent<PartClass>().gameObject;
        myPartClass = gameObject.GetComponentInParent<PartClass>();

        //set variable values
        padToCentre = -gameObject.transform.localPosition;
        inUse = false;
	
	}
	
	void Update () {
	
	}

    void OnTriggerEnter(Collider trigger) {

        //If collided with another attachment pad:
        if (trigger.GetComponent<AttachmentPad>() != null) {
            //provided neither are in use:
            if(!getInUse() && !trigger.GetComponent<AttachmentPad>().getInUse()) {
                //If we are attached...
                if (myPartClass.getAttachmentStatus())
                {
                    //...and they are NOT attached.
                    if (!trigger.GetComponent<AttachmentPad>().getPartClass().getAttachmentStatus())
                    {
                        AttachThemToUs(trigger.GetComponent<AttachmentPad>(), trigger.GetComponent<AttachmentPad>().myPartClass);
                    }
                    //...and they ARE attached.
                    else
                    {
                        if (debug) { Debug.Log("Cannot attach " + trigger.GetComponent<AttachmentPad>().getPart().name + " and " + myPart.name + " as both are attached to the robot already."); }
                    }
                }
            }
        }        
    }

    private void AttachThemToUs(AttachmentPad triggeredAttachPad, PartClass triggeredPartClass) {
        triggeredPartClass.setPhysics(false);
        triggeredPartClass.transform.position = gameObject.transform.position + (gameObject.transform.up * triggeredAttachPad.getPadToCentre().magnitude);
        triggeredPartClass.transform.parent = myPart.transform;

        /* Vector3 diffVector = transform.forward + triggeredAttachPad.transform.forward;
        triggeredPartClass.transform.Rotate(diffVector); */

        //set attachmentStatus
        triggeredPartClass.setAttachmentStatus(true);
        //set their robotCore correctly
        triggeredPartClass.setRobotCore(myPartClass.getMyRobotCore());

        //set use for both attachment pads
        setInUse(true);
        triggeredAttachPad.setInUse(true);

    }

    /*GET AND SET METHODS
    ALSO KNOWN AS
    "WOO I DO COMPUTER SCIENCE
    LOOK AT ME" */

    public GameObject getPart() { return myPart; }
    public PartClass getPartClass() { return myPartClass; }
    public Vector3 getPadToCentre() { return padToCentre; }

    public bool getInUse() { return inUse; }
    public void setInUse(bool status)
    {
        inUse = status;
    }
}
