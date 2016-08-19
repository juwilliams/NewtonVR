using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RPDMPlayer : NewtonVR.NVRPlayer {

    public RPDMInventory Inventory;

    // Use this for initialization
    void Start () {
        this.Inventory = this.GetComponent<RPDMInventory>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
