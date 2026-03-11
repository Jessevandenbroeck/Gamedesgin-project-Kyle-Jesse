using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform target;   // The center point
    public float speed = 3f;

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