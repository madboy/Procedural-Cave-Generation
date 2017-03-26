using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        //Vector3 pos = new Vector3(-70 / 2 + 10 + .5f, 0, -70 / 2 + 10 + .5f);
        Gizmos.DrawCube(transform.position, new Vector3(10, 10, 10));
        //Gizmos.DrawCube(pos, new Vector3(10, 10, 10));
    }
}
