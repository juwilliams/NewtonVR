using UnityEngine;
using System.Collections;

public class RPDMHand : NewtonVR.NVRHand {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();

        Vector3 toHeadVector = (SteamVR_Render.Top().transform.position - this.transform.position).normalized;

        if (Vector3.Dot(toHeadVector, transform.forward) > 0)
        {
            Debug.Log("Hand is behind head!");

            if (!IsInteracting && UseButtonPressed)
            {

            }
        }
	}
}
