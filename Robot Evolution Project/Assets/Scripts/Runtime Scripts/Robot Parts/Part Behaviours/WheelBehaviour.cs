using UnityEngine;
using System.Collections;

public class WheelBehaviour : MonoBehaviour {

    private PartClass myPartClass;
    private const float WHEEL_TORQUE = 2;
    
	void Start () {

        myPartClass = GetComponentInParent<PartClass>();
	
	}
	
	void FixedUpdate () {

        //if the part is attached...
        if(myPartClass.getAttachmentStatus())
        {
            if (myPartClass.getMyRobotCore().GetComponent<Rigidbody>() != null)
            {
                Rigidbody coreBody = myPartClass.getMyRobotCore().GetComponent<Rigidbody>();
                if (Input.GetKey(KeyCode.A)) { coreBody.AddTorque(coreBody.transform.forward * WHEEL_TORQUE); }
                if (Input.GetKey(KeyCode.D)) { coreBody.AddTorque(-coreBody.transform.forward * WHEEL_TORQUE); }
                if (Input.GetKey(KeyCode.W)) { coreBody.AddTorque(coreBody.transform.up * WHEEL_TORQUE); }
                if (Input.GetKey(KeyCode.S)) { coreBody.AddTorque(-coreBody.transform.up * WHEEL_TORQUE); }
            }

            
        }
	
	}

    public void OnAttach()
    {

    }
    public void OnDetach()
    {

    }
}
