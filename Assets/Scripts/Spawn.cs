using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Spawn : MonoBehaviour
{

    public static Spawn instance;
    [Header("Score")]
    public static int scores = 0;
    public Animator anim;
    [Header("ParticleSystem")]
    public ParticleSystem redBallEffect;
    public ParticleSystem applesEffect;
    public ParticleSystem crystalEffect;
    public static bool isTap = false;
  public static bool isCrystalTap = false;
    public static bool isBombTap = false;
    private void Awake()
    {
        instance = this;
      
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    

    //When player touches the GreenApple
   public  void IncreaseScore()
    {
      
        Instantiate(applesEffect, transform.position, Quaternion.identity);
        scores++;
        isTap = true;
        Destroy(gameObject);
       

    }
    
    // When player touches the bombRed
    public void DecreaseScore()
    {
       Instantiate(redBallEffect,transform.position, Quaternion.identity);    
        scores-=3;
      isBombTap=true;   
        Destroy(gameObject);
    }

    //When player touches the Crystal
    public void PowerUp()
    {
        isCrystalTap=true;
        Instantiate(crystalEffect, transform.position, Quaternion.identity);
        scores +=5;
        Destroy(gameObject);    

    }
}
