using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void begin()
    {
        SceneManager.LoadScene("Level");
    }

    public void Quit()
    {
        Application.Quit();
    }
    
    public void select()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
