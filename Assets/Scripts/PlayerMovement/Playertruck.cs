using UnityEngine;

public class Playertruck : MonoBehaviour



{


    public float moveSpeed;
    float Xinput;
    float Yinput;

    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Xinput = Input.GetAxis("Horizontal");
        Yinput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.AddForce(Xinput * moveSpeed, 0, Yinput * moveSpeed);
    }
}
