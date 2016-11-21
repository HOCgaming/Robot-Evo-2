using UnityEngine;
using System.Collections;

public class CoreBehaviour : MonoBehaviour {

    private PartClass myPartClass;

	// Use this for initialization
	void Start () {

        myPartClass = GetComponentInParent<PartClass>();
        
        if (myPartClass.getPartType() == PartController.partTypes.CORE)
        {
            myPartClass.setAttachmentStatus(true);
            myPartClass.setRobotCore(gameObject.GetComponent<PartClass>());
            PartController.robotCores.Add(gameObject.GetComponent<PartClass>());
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
