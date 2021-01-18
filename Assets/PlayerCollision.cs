using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Player_movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
