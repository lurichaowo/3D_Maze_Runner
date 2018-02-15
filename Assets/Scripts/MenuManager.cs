using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject exitMenu;
    public GameObject instructions;
    public GameObject credits;

    void Start()
    {
    }

    void Update()
    {
        if (instructions.activeInHierarchy == false && credits.activeInHierarchy == false)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                exitMenu.SetActive(true);
            }
        }
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
