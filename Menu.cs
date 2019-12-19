using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject sound,botonStart, botonExit, botonControls, atras,controlesImg;
    //public AudioClip music;
    int num;
    public AudioSource musica;

    void Start()
    {
        musica = GetComponent<AudioSource>();
        num = Random.Range(1, 4);
    }
    void Update()
    {
        
    }

    public void PlayJuego()
    {
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene(num);
        print(num);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void mute()
    {
        //sound.SetActive(true);
        //AudioPlayer.clip = music;
        musica.Pause();
        //musica.Stop();

    }
    public void Nomute()
    {
        //sound.SetActive(true);
        //AudioPlayer.clip = music;
        musica.Play();
        //sound.SetActive(true);

    }

    public void MenuAtras()
    {
        botonStart.SetActive(true);
        botonExit.SetActive(true);
        atras.SetActive(false);
        botonControls.SetActive(true);
        controlesImg.SetActive(false);

    }

    public void Controls()
    {
        botonControls.SetActive(false);
        botonStart.SetActive(false);
        botonExit.SetActive(false);
        atras.SetActive(true);
        //sound.SetActive(true);
        controlesImg.SetActive(true);
        
    }
}
