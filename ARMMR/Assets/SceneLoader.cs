using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1;

    // Update is called once per frame
    void Update()
    {
      
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadMyScene(SceneManager.GetActiveScene().buildIndex + 1));
    }
    public void LoadPreviousScene()
    {
        StartCoroutine(LoadMyScene(SceneManager.GetActiveScene().buildIndex -1));
    }

    IEnumerator LoadMyScene(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
