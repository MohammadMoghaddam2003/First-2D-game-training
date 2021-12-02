using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    static int _score ;
    public static int score 
     { 
         get
         {
            return _score;
         } 
         set
         {
            if (value > _score + 1)
            {
                value =1 ;
            }
            else
            {
                _score = value;
            }
         }
     }
    public Text scoreText ;



    private void Start() 
    {
        _score = PlayerPrefs.GetInt("PlayerScore");
        scoreText.text = _score.ToString("000");
    }

    void Update() 
    {
        PlayerPrefs.SetInt("PlayerScore",score);
        scoreText.text = PlayerPrefs.GetInt("PlayerScore").ToString("000");
    }
}
