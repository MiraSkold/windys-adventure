using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public string scene;
    public void Play()
    {
        SceneManager.LoadScene(scene);
    }

}
