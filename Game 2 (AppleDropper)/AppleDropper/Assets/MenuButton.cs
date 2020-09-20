using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackToGame()
    {
        Manager.instance.UnpauseGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void Restart()
    {

    }
}
