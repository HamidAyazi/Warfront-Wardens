using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private float MovementSpeed;
    private float offSet = 0.4f;
    private int wavepointIndex = 0;
    private Vector3 randomTarget; // The random target position near the actual target

    private void Start()
    {
        target = WaypointsScript.points[wavepointIndex];
        randomTarget = target.position;
        MovementSpeed = GetComponent<Enemy>().EnemyType.MovementSpeed;
    }

    private void Update()
    {
        // Move towards random location near actual target
        Vector3 dir = randomTarget - transform.position;
        transform.Translate(dir.normalized * MovementSpeed * Time.deltaTime);
        // Calculate the random target position only if the enemy has reached the current target
        if (Vector3.Distance(target.position, transform.position) <= offSet)
        {
            GetNextWaypoint();
            CalculateRandomTarget();
        }
    }

    private void GetNextWaypoint()
    {
        if (wavepointIndex >= WaypointsScript.points.Length - 1)
        {
            Destroy(gameObject);
        }
        else
        {
            wavepointIndex++;
            target = WaypointsScript.points[wavepointIndex];
        }
    }

    private void CalculateRandomTarget()
    {
        // Generate a random offset within the specified range
        Vector2 randomOffset = Random.insideUnitCircle * offSet;
        randomTarget = target.position + new Vector3(randomOffset.x, randomOffset.y, 0);
    }
}
