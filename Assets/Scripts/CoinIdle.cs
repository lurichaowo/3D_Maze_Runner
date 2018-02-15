
using UnityEngine;
using System.Collections;

public class CoinIdle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(Vector3.forward, 120f * Time.deltaTime);
    }

}
