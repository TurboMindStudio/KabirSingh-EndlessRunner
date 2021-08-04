using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb;
    public Transform feetPosition;
    public LayerMask ground;
    public float checkRadius;
    bool isGrounded;
    public GameObject explosion;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPosition.position, checkRadius, ground);

        if (isGrounded)
        {
            jump();
        }

        

    }

    void jump()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       

        if (other.CompareTag("coin"))
        {
            
            scoreManager.scorevalue++;
            menManager.instance.currentScoreText.text = scoreManager.scorevalue.ToString();
            soundManager.soundManagerinstance.audioSource.PlayOneShot(soundManager.soundManagerinstance.coinsound);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("baricate"))
        {
            menManager.instance.restartScreen.SetActive(true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            soundManager.soundManagerinstance.audioSource.PlayOneShot(soundManager.soundManagerinstance.explosionSound);
            Destroy(gameObject);

            if (PlayerPrefs.HasKey("highScore"))
            {
                if (PlayerPrefs.GetInt("highScore") < scoreManager.scorevalue)
                {
                    PlayerPrefs.SetInt("highScore", scoreManager.scorevalue);
                    Debug.Log("new Highscore");
                    menManager.instance.highscoreText.text = scoreManager.scorevalue.ToString();
                }
                else
                {
                    Debug.Log("no HighScore");
                    menManager.instance.highscoreText.text = PlayerPrefs.GetInt("highScore").ToString();
                }
            }
            else
            {
                PlayerPrefs.SetInt("highScore", scoreManager.scorevalue);
            }


        }
    }

  
}
