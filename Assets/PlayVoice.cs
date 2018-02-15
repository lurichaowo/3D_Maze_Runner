using UnityEngine;
using System.Collections;

public class PlayVoice : MonoBehaviour {
    // Use this for initialization
    void OnCollisonEnter()
    {
        GetComponent<AudioSource>().Play();
    }
}
