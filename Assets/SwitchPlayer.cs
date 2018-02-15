using UnityEngine;
using System.Collections;


public class SwitchPlayer : MonoBehaviour
{
    public GameObject unityhw;
    public GameObject unityhwF;
    // Use this for initialization
    void Start()
    {
        //unityhw = GameObject.FindGameObjectWithTag("PlayerF");
        //unityhwF = GameObject.FindGameObjectWithTag("Player3");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (unityhw.activeInHierarchy)
            {
                unityhwF.SetActive(true);
                unityhwF.transform.position = new Vector3(unityhw.transform.position.x, transform.position.y, unityhw.transform.position.z);
                unityhwF.transform.rotation = unityhw.transform.rotation;
                unityhw.SetActive(false);
            }
            else if (unityhwF.activeInHierarchy)
            {
                unityhw.SetActive(true);
                unityhw.transform.position = new Vector3(unityhwF.transform.position.x, transform.position.y, unityhwF.transform.position.z);
                unityhw.transform.rotation = unityhwF.transform.rotation;
                unityhwF.SetActive(false);
            }
        }
    }
}