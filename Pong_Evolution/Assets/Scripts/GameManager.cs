using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform paddle_1; 
    [SerializeField] Transform paddle_2;
    [SerializeField] Transform ball;

    void Update()
    {
        if (StateManager.Instance.currentState == StateManager.GameStates.GameOver)
        {
            ResetLevel();
        }
    }

    void ResetLevel()
    {
        paddle_1.position = new Vector2(8, 0);
        paddle_2.position = new Vector2(-8, 0);

        ball.position = new Vector2(0, 0);

        StateManager.Instance.currentState = StateManager.GameStates.Idle;
    }
}
