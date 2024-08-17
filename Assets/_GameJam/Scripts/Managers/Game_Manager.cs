using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    private string[] LevelAssets = new string[] { "Camera_Manager", "Enemy_Manager", "Map_Manager" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (string level in LevelAssets) {
            SceneManager.LoadSceneAsync(level, LoadSceneMode.Additive);
        }
    }

}
