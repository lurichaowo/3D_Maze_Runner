using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public Transform end;
    public string thing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == thing)
        {
            transform.position = end.position;
        }
    }
}
