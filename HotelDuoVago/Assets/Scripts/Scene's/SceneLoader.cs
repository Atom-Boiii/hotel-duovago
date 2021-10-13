using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnSceneLoad(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ASyncLoad(int scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }
}
