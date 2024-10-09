using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    //Scene manager script
    public AudioSource aud;
    public AudioClip butt;
    public GameObject about;
    public GameObject pausePan;
    bool ispress = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level1Scene()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(1);
    }
    public void level2Scene()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(2);
    }
    public void level3Scene()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(3);
    }
    public void level4Scene()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(4);
    }
    public void level5Scene()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(5);
    }
    public void HomeScene()
    {
        Time.timeScale = 1;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(0);
    }
    public void restartLevel1()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        SceneManager.LoadScene(1);
        
    }
    public void restartLevel2()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        SceneManager.LoadScene(2);

    }
    public void restartLevel3()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        SceneManager.LoadScene(3);

    }
    public void restartLevel4()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        SceneManager.LoadScene(4);

    }
    public void restartLevel5()
    {
        Time.timeScale = 1;
        Spawn.scores = 0;
        SceneManager.LoadScene(5);

    }
   
    public void Back()
    {
        about.SetActive(false); 
    }
    public void On()
    {
        about.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();    
    }
    public void PauseButt()
    {
        pausePan.SetActive(true);
       
            Time.timeScale = 0;
            ispress = true;
        
        

    }
    public void BackPauseBut()
    {
        pausePan.SetActive(false);
       
            Time.timeScale = 1;
            ispress = false;
        

        
    }
}
