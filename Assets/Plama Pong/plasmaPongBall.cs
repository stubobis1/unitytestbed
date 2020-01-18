using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plasmaPongBall : MonoBehaviour
{
    public GameManager GM;
    public Rigidbody2D rb;
    public GameObject Explosion;

    public float StartSpeed = 1f;
    private void Start()
    {
        if (rb == null)
        {
            rb = this.GetComponent<Rigidbody2D>();
        }
        ResetBall();
    }

    private void ResetBall()
    {
        //this.rb.AddForce(new Vector2((Random.value - 0.5f) * 3f, Random.value - 0.5f).normalized, ForceMode2D.Impulse);
        this.rb.AddForce(new Vector2(-15f, 0f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player1Score")
        {
            print("Player1Score");
            playerScore(1);
        }
        if (collision.gameObject.tag == "player2Score")
        {
            print("Player2Score");
            playerScore(2);
        }
    }

    void playerScore(int playerNum)
    {
        GM.Score(playerNum);

        Instantiate(Explosion, new Vector3(this.transform.position.x, this.transform.position.y),Quaternion.identity);
        Destroy(this.gameObject);
        //Instantiate();
    }
}

