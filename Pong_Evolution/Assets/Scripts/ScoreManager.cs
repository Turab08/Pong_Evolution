using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int scorePlayer1 = 0;
    public int scorePlayer2 = 0;

    public TMP_Text scorePlayer1Text;
    public TMP_Text scorePlayer2Text;

    public static ScoreManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore(int playerIndex) 
    {
        if (playerIndex == 1) {
            scorePlayer1 += 1;
            scorePlayer1Text.text = scorePlayer1.ToString();
        }
        else
        {
            scorePlayer2 += 1;
            scorePlayer2Text.text = scorePlayer2.ToString();
        }
    }
}
