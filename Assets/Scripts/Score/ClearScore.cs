using UnityEngine;

public class ClearScore : MonoBehaviour
{
    private void Start() {
        
    }
     
    private void Update() {
        
    }


    public void OnClickDown() 
    {
        PlayerPrefs.DeleteKey("PlayerScore");
        ScoreManager.score = 0;
    }
}
