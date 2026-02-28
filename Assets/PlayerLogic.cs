using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float speed = 5f;
    public GameObject projectilePrefab;  
    public Transform projectileSpawnPoint;  

    private void Update()
    {
        //Move the player
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * move * speed * Time.deltaTime);

        //Shoot projectiles when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
    }
}