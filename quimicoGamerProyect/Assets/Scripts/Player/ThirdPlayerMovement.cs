using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPlayerMovement : MonoBehaviour
{
   // public Rigidbody rb;

    public CharacterController controller; 
    public Transform cam; 

    public float speed = 6f;

    float turnSmothTime = 0.1f; 
    float turnSmoth; 
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float veertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, veertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngel = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngel, ref turnSmoth, turnSmothTime); 
            transform.rotation = Quaternion.Euler(0f, angle,0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngel, 0f) * Vector3.forward;
            controller.Move(moveDir * speed * Time.deltaTime); 
            //rb.transform.Translate(moveDir.normalized * speed * Time.deltaTime);
        }
    }
}
