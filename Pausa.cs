using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    bool active;
    public GameObject pausa, play,inputGUI, inputGUI2,volverMenu;

    void Start()
    {
        pausa.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();//cierra
        }
    }

    public void Pause()
    {
       
            Time.timeScale = 0; //si esta activa pone a 0, se para, sino a 1, en funcionamiento
            pausa.SetActive(false);
            play.SetActive(true);
            inputGUI.SetActive(false);
        inputGUI2.SetActive(false);
        volverMenu.SetActive(true);
        print("input");
        
    }

    public void Play()
    {
        pausa.SetActive(true);
        play.SetActive(false);
        Time.timeScale = 1;
        inputGUI.SetActive(true);
        inputGUI2.SetActive(true);
        volverMenu.SetActive(false);

    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;

    }
}
