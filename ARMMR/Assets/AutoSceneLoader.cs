using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AutoSceneLoader : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMyScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        
    }

    IEnumerator LoadMyScene(int levelIndex)
    {

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
