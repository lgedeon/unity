using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

   bool gameHasEnded = false;
   public float restartDelay = 1f;
   public GameObject completeLevelUI;

   public void completeLevel () {
       Debug.Log("CompleteLevel");
      completeLevelUI.SetActive(true);
   }

   public void EndGame () {
       Debug.Log("EndGame");
       if (gameHasEnded == false) {
           Debug.Log("EndGame if false set true");
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
       }
          
   }

   void Restart () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Restart");
    }

}
