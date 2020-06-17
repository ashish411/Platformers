using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private Text _score, _lives;
    // Start is called before the first frame update
    
     public void UpdateScore(int score)
    {
        _score.text = "Score: " + score;
    }
    
    public void UpdateLives(int lives)
    {
        _lives.text = "Lives: " + lives;
    }


}
