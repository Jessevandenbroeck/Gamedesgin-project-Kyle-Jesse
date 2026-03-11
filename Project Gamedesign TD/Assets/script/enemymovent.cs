using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target;   // The center point
    public float speed = 3f;

public class EnemyDeath : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
    void Update()
    {
        if (target == null) return;

        // Move enemy toward target
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );
    }
}