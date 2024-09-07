using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 1000f;
    public float sideways = 600f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideways * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < 1f)
        {
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
