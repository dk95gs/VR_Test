    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrab : MonoBehaviour {

    public Transform dest;

    public void PickUp()
    {
    
        this.transform.position = dest.position;
        this.transform.parent = GameObject.Find("Hand").transform;
		this.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Drop()
    {
        this.transform.parent = null;
        
    }
}
