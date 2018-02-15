using UnityEngine;
using System.Collections;

public class Yuko_Move : MonoBehaviour {

    Animator yuko;
    int jumpHash = Animator.StringToHash("Jumping@loop");

    void Start()
    {
        yuko = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        yuko.SetFloat("Speed", move);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            yuko.SetTrigger(jumpHash);
        }
    }
}