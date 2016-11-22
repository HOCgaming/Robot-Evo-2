using UnityEngine;
using System.Collections;

public class WheelBehaviour : MonoBehaviour {

    private PartClass myPartClass;
    
	void Start () {

        myPartClass = GetComponentInParent<PartClass>();
	
	}
	
	void FixedUpdate () {

        //if the part is attached...
        if(myPartClass.getAttachmentStatus())
        {
            if(Input.GetKey(KeyCode.A)) { }
            if(Input.GetKey(KeyCode.D)) { }
        }
	
	}

    public void OnAttach()
    {

    }
    public void OnDetach()
    {

    }
}
