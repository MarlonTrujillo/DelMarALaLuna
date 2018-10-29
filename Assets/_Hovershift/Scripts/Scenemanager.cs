using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour {

	public void cambiarscena()
    {
        SceneManager.LoadScene("Main");
    }

    public void playCinematic()
    {
        SceneManager.LoadScene("Cinematic2");
    }
}
