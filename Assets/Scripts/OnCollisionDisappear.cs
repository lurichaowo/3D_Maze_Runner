using UnityEngine;
using System.Collections;

public class OnCollisionDisappear : MonoBehaviour
{

    public string thing;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == thing)
        {
            Destroy(col.gameObject);
        }
    }
}