using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScene : MonoBehaviour
{
    public int scene;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Load());
    }

    private IEnumerator Load()
    {
        yield return new WaitForSeconds(2f);

        GetComponent<SceneLoader>().ASyncLoad(scene);

    }
}
