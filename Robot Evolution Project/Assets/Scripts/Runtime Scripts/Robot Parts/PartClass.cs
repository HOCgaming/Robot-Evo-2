using UnityEngine;
using System.Collections;

public class PartClass : MonoBehaviour {
    private bool debug = true;

    //Properties of each part of the robot
    [SerializeField] private bool attachmentStatus = false;
    public PartController.partTypes partType = new PartController.partTypes();

    void Start() {

        //The core of the robot is, by definition, already attached to the robot
        if (getPartType() == PartController.partTypes.CORE) {
            setAttachmentStatus(true);
        }
    }

    public void setPhysics(bool status) {
        
        //if looking to add a rigidbody
        if (status) {
            //if we already HAVE a rigidbody
            if (gameObject.GetComponent<Rigidbody>() != null) {
                /* DEBUG */
                if (debug) { Debug.Log(gameObject.name + " already has a rigidbody."); }
            }
            //if we DON'T have a rigidbody
            else {
                gameObject.AddComponent<Rigidbody>();
            }            
        }

        //if looking to remove a rigidbody
        else {
            //if we already HAVE a rigidbody
            if (gameObject.GetComponent<Rigidbody>() != null) {
                Destroy(gameObject.GetComponent<Rigidbody>());
            }
            //if we DON'T have a rigidbody
            else {
                /* DEBUG */
                if (debug) { Debug.Log(gameObject.name + " does not have a rigidbody."); }
            }
        }
    }

    /* GET and SET methods for each property of the part.
     * Look, I'm being a good Computer Scientist...
     */

    public bool getAttachmentStatus() { return attachmentStatus; }
    public void setAttachmentStatus(bool status)
    {
        attachmentStatus = status;
    }

    public PartController.partTypes getPartType() { return partType; }
}
