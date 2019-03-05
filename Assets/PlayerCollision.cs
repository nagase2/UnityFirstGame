

using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove movement;

     void OnCollisionEnter(Collision collisionInfo) {
         if(collisionInfo.collider.name == "Obstacle")
        {
            Debug.Log("we hit obstacle");
            movement.enabled = false;
        }
    }
}
