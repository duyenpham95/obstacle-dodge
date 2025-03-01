using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float flySpeed = 10.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        transform.position =
        Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * flySpeed);
    }
}
