using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript2 : MonoBehaviour
{

    public string StartGameScene;
    // Start is called before the first frame update
    void Start()
    {
        UnlockMouse();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level");
    }
    
    public void ls()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
