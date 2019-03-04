

using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnCollisionEnter(Collision collisionInfo) {
         Debug.Log(collisionInfo.collider.name);
        
    }
}
