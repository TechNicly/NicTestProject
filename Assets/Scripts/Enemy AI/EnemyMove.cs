using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;

    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            float distance = direction.magnitude;

            if (distance > 0.1f) // Adjust this threshold as needed
            {
                direction.Normalize();
                transform.position += direction * speed * Time.deltaTime;
            }
        }
    }
}