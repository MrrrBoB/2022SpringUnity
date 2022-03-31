using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{

    public int requiredKeyIndex;
    public LevelKeyManager keyM;
    public void loadScn(int scnfour)
    {
        SceneManager.LoadScene(scnfour);
    }

    public void LoadLockedScene(int sceneToLoad)
    {
        if (keyM.getKeyStatus(requiredKeyIndex))
        {
            loadScn(sceneToLoad);
        }
        else Debug.Log("Need Key");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
