using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{

    public int requiredKeyIndex;
    public LevelKeyManager keyM;
    public UnityEvent lockMessage;
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
        else lockMessage.Invoke();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
