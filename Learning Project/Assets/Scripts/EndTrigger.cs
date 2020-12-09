using UnityEngine;

public class EndTrigger : MonoBehaviour {
    
    public GameManager gameManager;

    void OnTriggerEnter () {
        Debug.Log("EndTrigger");
        gameManager.completeLevel();
    }
}
