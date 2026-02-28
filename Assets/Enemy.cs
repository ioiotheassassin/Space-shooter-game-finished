using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public float bottomY = -6f; 

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        //see if enemy passed bottom of screen
        if (transform.position.y < bottomY)
        {
            FindObjectOfType<GameManager>().GameOver();
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().GameOver();
            Destroy(gameObject);
        }
    }
}