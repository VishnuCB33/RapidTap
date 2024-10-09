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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level1Scene()
    {
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(1);
    }
    public void level2Scene()
    {
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(2);
    }
    public void level3Scene()
    {
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(3);
    }
    public void level4Scene()
    {
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(4);
    }
    public void level5Scene()
    {
        Spawn.scores = 0;
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(5);
    }
    public void HomeScene()
    {
        
        aud.PlayOneShot(butt);
        SceneManager.LoadScene(0);
    }
    public void restartLevel1()
    {
        Spawn.scores = 0;
        SceneManager.LoadScene(1);
        
    }
    public void restartLevel2()
    {
        Spawn.scores = 0;
        SceneManager.LoadScene(2);

    }
    public void restartLevel3()
    {
        Spawn.scores = 0;
        SceneManager.LoadScene(3);

    }
    public void restartLevel4()
    {
        Spawn.scores = 0;
        SceneManager.LoadScene(4);

    }
    public void restartLevel5()
    {
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
}
