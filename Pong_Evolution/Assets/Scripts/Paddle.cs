using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int paddleSpeed;
    public Rigidbody2D leftPaddle;
    public Rigidbody2D rightPaddle;

    float leftInput;
    float rightInput;

    void Update()
    {
        leftInput = 0;
        rightInput = 0;

        if (Input.GetKey(KeyCode.W))
        {
            leftInput = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            leftInput = -1;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rightInput = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rightInput = -1;
        }
    }

    void FixedUpdate()
    {
        leftPaddle.linearVelocity = new Vector2(0, leftInput * paddleSpeed);
        rightPaddle.linearVelocity = new Vector2(0, rightInput * paddleSpeed);
    }
}
