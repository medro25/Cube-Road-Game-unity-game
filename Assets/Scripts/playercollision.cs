using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public CubeMove movement;  // Ensure this matches the class name in CubeMove.cs

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Collision Detected with: " + collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstacle Hit");
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
