using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematicatimer : MonoBehaviour
{
    public float reloj = 0;
    public float relojsaltar = 0;
    public string scenetochange;
    public Color loadToColor = Color.white;
    public GameObject Saltar;
    //public GameObject objeto;
     

    // Update is called once per frame
    void Update()
    {
        relojsaltar -= Time.deltaTime;
        if (relojsaltar < 0)
        {
            Saltar.SetActive(true);
        }
        reloj -= Time.deltaTime;
        if (reloj < 0)
        {
            fadescene1();
            //objeto.SetActive(false);
            //SceneManager.LoadScene("Main");
               
        }
    }

    public void fadescene1()
    {
        Initiate.Fade(scenetochange, loadToColor, 1.0f);
    }
}
