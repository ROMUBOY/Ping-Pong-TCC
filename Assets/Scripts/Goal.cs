using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public enum PlayerPoint
    {
        Esquerdo,
        Direito
    }

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public PlayerPoint playerPoint;
    public GameObject ball;
    private int score = 0;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);

        score++;
        scoreText.text = score.ToString();

        if(score < 5)
        {
            Instantiate(ball, Vector3.zero, Quaternion.identity);
        }
        else
        {
            winText.text = "Vitória do lado " + playerPoint.ToString();
        }        
    }
}
