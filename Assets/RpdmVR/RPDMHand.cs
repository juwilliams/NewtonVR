using UnityEngine;
using System.Collections;

public class RPDMHand : NewtonVR.NVRHand {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	protected override void Update () {
        base.Update();

        //  inventory management trigger
        Vector3 cameraPosition = SteamVR_Render.Top().transform.position;
        Vector3 handPosition = this.transform.position;

        Vector3 toHeadVector = (cameraPosition - handPosition).normalized;

        float distanceToHead = Vector3.Distance(cameraPosition, handPosition);

        if (Vector3.Dot(toHeadVector, transform.forward) < 0 && distanceToHead < 1.3)
        {
            RPDMPlayer player = NewtonVR.NVRPlayer.Instance as RPDMPlayer;

            if (!IsInteracting && HoldButtonPressed && !RPDMInventoryManager.Instance.IsManaging)
            {
                RPDMInventoryManager.Instance.StartManaging(NewtonVR.NVRPlayer.Instance.GetComponent<RPDMInventory>());
            }

            if (IsInteracting && HoldButtonDown && RPDMInventoryManager.Instance.IsManaging)
            {
                RPDMInventoryManager.Instance.StopManaging();
            }
        }
	}
}
