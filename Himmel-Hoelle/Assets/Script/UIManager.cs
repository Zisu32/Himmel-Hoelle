using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public string sceneName;
    public string sceneName_2;
    public string sceneHowToPlay;
    public string sceneMainMenu;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
    public void CloseGame()
    {
        Application.Quit();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    
    public void LoadSceneHowToPlay()
    {
        SceneManager.LoadScene(sceneHowToPlay, LoadSceneMode.Single);
    }    
    
    public void LoadSceneMainMenu()
    {
        SceneManager.LoadScene(sceneMainMenu, LoadSceneMode.Single);
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(sceneName_2, LoadSceneMode.Single);
    }
}

