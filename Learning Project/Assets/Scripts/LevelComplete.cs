using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour {
    
    public GameManager gameManager;

    void OnTriggerEnter () {
        Debug.Log("Loading next level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
