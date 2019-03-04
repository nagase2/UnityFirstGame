

using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

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
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}

