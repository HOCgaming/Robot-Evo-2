using UnityEngine;
using System.Collections;

public class PartClass : MonoBehaviour {

    //Properties of each part of the robot
    private bool attachmentStatus = false;
    public PartController.partTypes partType = new PartController.partTypes();

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
