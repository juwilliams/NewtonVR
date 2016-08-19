using UnityEngine;
using System.Collections;

public class RPDMInventoryManager : MonoBehaviour {

    public static RPDMInventoryManager Instance;

    public bool IsManaging;

    // Use this for initialization
	void Start () {
        Instance = this;
        IsManaging = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartManaging(RPDMInventory inventory)
    {
        Debug.Log("Managing Inventory...");
        IsManaging = true;
    }

    public void StopManaging()
    {
        Debug.Log("Stopping Inventory Management...");
        IsManaging = false;
    }
}
