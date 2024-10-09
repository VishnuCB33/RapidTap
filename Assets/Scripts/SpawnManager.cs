using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class SpawnManager : MonoBehaviour
{
    public LevelTwo levels;
    [Header("ObjectSpawn")]
    public GameObject parentImage;
    public GameObject[] spawnObject;
    public GameObject resetPanel;
    int k = 0;
    [Header("Timer")]
    public float time;
    float resetTimer = 30f;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI targetScore;
    public TextMeshProUGUI panelScoreText;
    public GameObject gameOverPanel;
    public int scoreDemo;
    public TextMeshProUGUI highScoreText;
    [Header("Audios")]
    public AudioSource audio;
    public AudioClip appleSpawn;
    public AudioClip crystalTap;
    public AudioClip tapSound;
    public AudioClip bombTap;
   

   
    private void Awake()
    {
        parentImage.GetComponent<SpriteRenderer>().sprite = levels.levelImage;
    }
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
         InvokeRepeating(nameof(spawnApple), 1f, levels.appleSpawnTime);
      
        InvokeRepeating(nameof(SpawnBomb), 3f, levels.bombSpawnTime);
        InvokeRepeating(nameof(PowerUp), 5, levels.crystalSpawnTime);
        time=levels.timer;

        
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisp();
        TimerFun();
      
        scoreDemo = Spawn.scores;
       if (Spawn.isTap == true)
        {
            audio.PlayOneShot(tapSound);
            Spawn.isTap = false;
        }
       if(Spawn.isCrystalTap == true)
        {
            audio.PlayOneShot(crystalTap);
            Spawn.isCrystalTap = false;
        }
        if (Spawn.isBombTap == true)
        {
            audio.PlayOneShot(bombTap);
            Spawn.isBombTap = false;
        }
        if (scoreDemo >= levels.targetScore)
        {
            k = 1;
        }
    }

    //Spawn  apples in random
    void spawnApple()
    {
        audio.PlayOneShot(appleSpawn);
        GameObject child=Instantiate(spawnObject[0]);
        child.transform.SetParent(parentImage.transform, false);    
        RectTransform parentRect=parentImage.GetComponent<RectTransform>();
        float randomX=Random.Range(-parentRect.rect.width/2, parentRect.rect.width/2);
        float randomY= Random.Range(-parentRect.rect.height / 2, parentRect.rect.height / 2);
        child.GetComponent<RectTransform>().anchoredPosition = new Vector2(randomX, randomY); 
       
        Destroy(child,levels.appleDestroyTime);
        
    }

    //Spawn  BombRed in random
    void SpawnBomb()
    {
        GameObject child = Instantiate(spawnObject[1]);
        child.transform.SetParent(parentImage.transform, false);
        RectTransform parentRect = parentImage.GetComponent<RectTransform>();
        float randomX = Random.Range(-parentRect.rect.width / 2, parentRect.rect.width / 2);
        float randomY = Random.Range(-parentRect.rect.height / 2, parentRect.rect.height / 2);
        child.GetComponent<RectTransform>().anchoredPosition = new Vector2(randomX, randomY);
        Destroy(child, levels.bombDestroyTime);
    }

    //Spawn  Crystal in random
    void PowerUp()
    {
        
        GameObject child = Instantiate(spawnObject[2]);
        child.transform.SetParent(parentImage.transform, false);
        RectTransform parentRect = parentImage.GetComponent<RectTransform>();
        float randomX = Random.Range(-parentRect.rect.width / 2, parentRect.rect.width / 2);
        float randomY = Random.Range(-parentRect.rect.height / 2, parentRect.rect.height / 2);
        child.GetComponent<RectTransform>().anchoredPosition = new Vector2(randomX, randomY);
        Destroy(child, levels.crystalDestroyTime);
    }
    //Time 
    void TimerFun()
    {
        time -= Time.deltaTime;
        if (time < 10)
        {
            timerText.color = Color.red;
        }
        
        if (time < 0)
        {
            if (k == 1)
            {
                gameOverPanel.SetActive(true);
            }
            else
            {
                resetPanel.SetActive(true);
            }
            panelScoreText.text= scoreDemo.ToString();
            time = 0;
            CancelInvoke("SpawnBomb");
            CancelInvoke("spawnApple");
            
        }
        int minutes=Mathf.FloorToInt(time/60);  
        int seconds=Mathf.FloorToInt(time%60);
        timerText.text=string.Format("{0:00}:{1:00}",minutes,seconds); 
      
    }
    //Score display
    void scoreDisp()
    {
        targetScore.text = scoreDemo.ToString();
        if (scoreDemo > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoreDemo);
        }
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();

    }
}
