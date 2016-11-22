using UnityEngine;
using System.Collections;

public class RotorBehaviour : MonoBehaviour
{

    private PartClass myPartClass;
    private const float ROTOR_TORQUE = 10, ROTOR_VEL = 500;

    void Start()
    {

        myPartClass = GetComponentInParent<PartClass>();

    }

    void FixedUpdate()
    {

        //if the part is attached...
        if (myPartClass.getAttachmentStatus())
        {
            if (myPartClass.getMyRobotCore().GetComponent<Rigidbody>() != null)
            {
                Rigidbody coreBody = myPartClass.getMyRobotCore().GetComponent<Rigidbody>();
                if (Input.GetKey(KeyCode.Space)) { coreBody.AddForce(myPartClass.getMyRobotCore().transform.up * ROTOR_TORQUE); }
            }


        }

    }

    void Update()
    {
        //if the part is attached...
        if (myPartClass.getAttachmentStatus())
        {
            if (Input.GetKey(KeyCode.Space)) { transform.Rotate(myPartClass.transform.up, Time.deltaTime * ROTOR_VEL); }
        }
    }

    public void OnAttach()
    {

    }
    public void OnDetach()
    {

    }
    
}
