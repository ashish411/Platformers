using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private Text _score;
    // Start is called before the first frame update
    
     public void UpdateScore(int score)
    {
        _score.text = "Score: " + score;
    }

}
