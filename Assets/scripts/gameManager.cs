using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public Slider slider;
    public GameObject loadingWindow;
    public GameObject playButton;
    public GameObject creditWindow;
    public GameObject[] firstScreenObs;
    public GameObject[]menuObs;
    
    
    void Start()
    {
        loadingWindow.SetActive(false);
        creditWindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play(int sceneIndex)
    {
        StartCoroutine(loadScene(sceneIndex));
    }

    IEnumerator loadScene(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingWindow.SetActive(true);
        playButton.SetActive(false);
        while (!operation.isDone)
        {

            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            Debug.Log(progress);
            yield return null;
        }
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("app quit");
    }

   public void credit()
   {
        creditWindow.SetActive(true);
        for (int i = 0; i < firstScreenObs.Length; i++)
        {
            firstScreenObs[i].SetActive(false);
        }
   }

    public void youtubeButton()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCLZ5n72RW1T4-lEHeHjudYA");
    }public void instagramButton()
    {
        Application.OpenURL("https://www.instagram.com/shivam_choudhari_official/");
    }

    public void backButton()
    {
        creditWindow.SetActive(false);

        for (int i = 0; i < menuObs.Length; i++)
        {
            menuObs[i].SetActive(true);
        }
    }
}
