using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SwitchToGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
