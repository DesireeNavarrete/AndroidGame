using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones2 : MonoBehaviour
{
    public GUITexture P2; //botones
    public GameObject coche2;
    float velocidad = 2.5f;
    public bool giroD, giroI, noGiro;
    int contTouch;


    void Start()
    {
        contTouch = 0;
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();//cierra
        }

        float Vx = velocidad * Time.deltaTime;
        coche2.transform.Translate(-Vx, 0, 0);

       
        //INPUT
        if (Input.touchCount > 0)
        {
            if (P2.HitTest(Input.GetTouch(0).position))//Solo entra si es touch es  con un dedo y le das al boton
            {

                if (Input.GetTouch(0).phase == TouchPhase.Began)// began: solo detecta toque
                {
                }
                if (Input.GetTouch(0).phase == TouchPhase.Stationary)//mientras el dedo este pulsando
                {

                    if (contTouch < 3)
                    {
                        contTouch++;
                        print("contTouchIF = " + contTouch);
                    }

                    if (contTouch == 1)
                    {
                        print("Giro a la derecha");
                        giroD = true;
                    }

                    if (contTouch == 3)
                    {

                        contTouch = 1;
                        giroD = true;
                        giroI = false;
                    }

                    if (contTouch == 2)
                    {
                        print("Giro a la izquierda: " + contTouch);
                        giroI = true;
                    }

                    if (giroD)
                    {
                        coche2.transform.Rotate(0, 0, -10);
                    }
                    
                }

                if (Input.GetTouch(0).phase == TouchPhase.Moved)//cuando arrastras el dedo
                {

                }
                if (Input.GetTouch(0).phase == TouchPhase.Ended)//al levantar el dedo y terminar el toque
                {
                }

                
            }

            if (P2.HitTest(Input.GetTouch(1).position))//Solo entra si es touch es  con un dedo y le das al boton
            {

                if (Input.GetTouch(1).phase == TouchPhase.Began)// began: solo detecta toque
                {
                }
                if (Input.GetTouch(1).phase == TouchPhase.Stationary)//mientras el dedo este pulsando
                {

                    if (contTouch < 3)
                    {
                        contTouch++;
                        print("contTouchIF = " + contTouch);
                    }

                    if (contTouch == 1)
                    {
                        print("Giro a la derecha");
                        giroD = true;
                    }

                    if (contTouch == 3)
                    {

                        contTouch = 1;
                        giroD = true;
                        giroI = false;
                    }

                    if (contTouch == 2)
                    {
                        print("Giro a la izquierda: " + contTouch);
                        giroI = true;
                    }

                    if (giroD)
                    {
                        coche2.transform.Rotate(0, 0, -10);
                    }


                }

                if (Input.GetTouch(1).phase == TouchPhase.Moved)//cuando arrastras el dedo
                {

                }
                if (Input.GetTouch(1).phase == TouchPhase.Ended)//al levantar el dedo y terminar el toque
                {
                }
            }
        }
    }
}
