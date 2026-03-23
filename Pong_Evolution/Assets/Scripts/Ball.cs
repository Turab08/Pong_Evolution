using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float ballSpeed;
    Vector2 direction;
    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && StateManager.Instance.currentState == StateManager.GameStates.Idle) {
            StartGame();
        }
    }

    void StartGame()
    {
        direction = Random.insideUnitCircle.normalized; 
        rb.velocity = direction * ballSpeed;

        StateManager.Instance.currentState = StateManager.GameStates.Playing;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall1"))
        {
            ScoreManager.Instance.AddScore(1);
            StateManager.Instance.currentState = StateManager.GameStates.GameOver;
        }
        else if (collision.gameObject.CompareTag("Wall2"))
        {
            ScoreManager.Instance.AddScore(2);
            StateManager.Instance.currentState = StateManager.GameStates.GameOver;
        }

        direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        rb.velocity = direction * ballSpeed;
    }
}
