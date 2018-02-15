using UnityEngine;
using System.Collections;

public class CoinCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject, .5f);
        }
    }
}
