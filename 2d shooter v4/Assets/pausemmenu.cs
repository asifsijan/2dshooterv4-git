using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemmenu : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject startMenuUI;
    public GameObject Slider;
    public GameObject ScoreText;



    void Start()
    {
        startMenuUI.SetActive(true);
        Slider.SetActive(false);
        ScoreText.SetActive(false);
        Time.timeScale = 0f;


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else

            {

                Pause();



            }
        }
    }

       public void Resume(){

                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
        Slider.SetActive(true);
        ScoreText.SetActive(true);

    }

          public  void Pause()
            {
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
        Slider.SetActive(false);
        ScoreText.SetActive(false);

    }

    public void StartAction()
    {
        startMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Slider.SetActive(true);
        ScoreText.SetActive(true);



    }

    public void Restart(){
        SceneManager.LoadScene("SampleScene");
        


    }

    public void ExitAction()
    {
        Application.Quit();
       
    }


        
    
}