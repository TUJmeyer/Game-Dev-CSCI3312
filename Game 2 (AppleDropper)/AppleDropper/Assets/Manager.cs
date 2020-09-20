using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Manager : MonoBehaviour
{
    public static Manager instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance)
            Destroy(gameObject);
        else
            instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                PauseGame();
            }
            else
                UnpauseGame();
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("Pause", LoadSceneMode.Additive);
    }
    public void UnpauseGame()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync("Pause");
    }
}
