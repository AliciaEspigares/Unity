using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
    public int speedrotate;
    public int speedmove;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(1,0,0)*Time.deltaTime*speedmove,Space.World);
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime*speedrotate);
        

		
	}
}
