using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForceForward=2000f;
    public float sideWaysForce=500f;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,ForceForward * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow)){
        rb.AddForce(sideWaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    if(Input.GetKey(KeyCode.LeftArrow)){
        rb.AddForce(-sideWaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
    }
    if(rb.position.y<-1f){
        FindObjectOfType<GameManager>().EndGame();
        
    }

}
}
