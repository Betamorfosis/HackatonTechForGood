using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int currentScene = int.Parse(SceneManager.GetActiveScene().name);
            if (currentScene == 1)
            {
                currentScene = 6;
            }
            else
            {
                currentScene--;
            }
            SceneManager.LoadScene(currentScene.ToString());
        }
    }
}
