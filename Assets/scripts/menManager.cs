using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menManager : MonoBehaviour
{
    public static menManager instance;
    public GameObject restartScreen;
    public Text highscoreText;
    public Text currentScoreText;
    public Animator fadeAnim;
    
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        restartScreen.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartButton()
    {
        scoreManager.scorevalue = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void menuButton()
    {
        soundManager.soundManagerinstance.bgSound.mute = true;
        StartCoroutine("panelFade");
    }

   IEnumerator panelFade()
    {
        fadeAnim.SetTrigger("end");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("menu");
    }

    
}
