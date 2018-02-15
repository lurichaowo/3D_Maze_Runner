using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpawnSD : MonoBehaviour
{
    public int _w, _h;
    public GameObject[] SDspawn;
    public float sizew;
    public float sizeh;


    // Use this for initialization
    void Start()
    {
        _w = GameObject.FindGameObjectWithTag("maze").GetComponent<MazeGenerator>()._width;
        _h = GameObject.FindGameObjectWithTag("maze").GetComponent<MazeGenerator>()._height;
        SDspawn = GameObject.FindGameObjectsWithTag("chibi");
        sizew = GameObject.FindGameObjectWithTag("cell").GetComponent<Renderer>().bounds.size.x;
        sizeh = GameObject.FindGameObjectWithTag("cell").GetComponent<Renderer>().bounds.size.z;

        foreach (GameObject spawn in SDspawn)
        {
            SpawnChibis(spawn);
        }
    }

    void Update()
    {
        if (Input.GetKey("q"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void SpawnChibis(GameObject c)
    {
        int rand = Random.Range(1, _w - 1);
        int rand2 = Random.Range(1, _h - 1);
        Vector3 center = new Vector3((rand * sizew), 0.25f, (rand2 * sizeh));
        Collider[] hitColliders = Physics.OverlapSphere(center, 1f);
        if (hitColliders.Length > 0)
        {
            SpawnChibis(c);
        }
        else
        {
            c.transform.position = center;
        }
    }

    // Update is called once per frame

}
