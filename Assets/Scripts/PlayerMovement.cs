using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum PlayerNumber 
    {
        Player1 = 1,
        Player2 = 2
    }

    public PlayerNumber playerNumber;

    public float speed = 1;

    private KeyCode upMovementButton = KeyCode.UpArrow;
    private KeyCode downMovementButton = KeyCode.DownArrow;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        if(playerNumber == PlayerNumber.Player2)
        {
            upMovementButton = KeyCode.W;
            downMovementButton = KeyCode.S;
        }

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {   
        if(Input.GetKey(upMovementButton))
        {
            rb.velocity = Vector2.up * speed;
        }
        else if(Input.GetKey(downMovementButton))
        {
            rb.velocity = Vector2.down * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

}