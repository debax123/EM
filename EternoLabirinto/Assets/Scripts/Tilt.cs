using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    public bool isFlat = true;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        rigid.AddForce(tilt * 15);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);
        //Input for Keyboard testing
        {
            /*+ M
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(h ,0 ,v ));
        if (movement)
        gameObject.transform.Translate(Input.acceleration.x * playerSpeedMult * Time.deltaTime, 0, Input.acceleration.y * playerSpeedMult * Time.deltaTime);
        */
        }
        //
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plate"))
        {
        }
    }
}
