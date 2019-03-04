

using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody rb;
  
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        // Debug.Log("hello world!");
        // rb.useGravity = false;
        //rb.AddForce(0,200,500);
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //deltaTimeをかけることで、フレームレートに依存しなくなる。
        rb.AddForce(0,0,2000 * Time.deltaTime);
     
    }
}

