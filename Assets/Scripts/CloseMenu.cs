using UnityEngine;
using System.Collections;

public class CloseMenu : MonoBehaviour {

    public GameObject menu;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(false);
        }
	
	}

    public void close()
    {
        menu.SetActive(false);
    }
}
