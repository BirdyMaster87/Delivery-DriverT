using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    // Start is called before the first frame update
    // [SerializeField] float RoteVal = 0.2f;
    // [SerializeField] float TransVal = 0.01f;
    [SerializeField] float steerSpeed=300f;
    [SerializeField] float moveSpeed=20f;
    [SerializeField] float slowSpeed=20f;
    [SerializeField] float mudSpeed=10f;
    [SerializeField] float boostSpeed=30f;

    // Update is called once per frame
    void Update()
    {
      float RoteVal = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
      float TransVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
      transform.Rotate(0,0,RoteVal);
      transform.Translate(0,TransVal,0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
      moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Boost")
      {
        moveSpeed = boostSpeed;
      }

      if(other.tag == "Mud")
      {
        moveSpeed = mudSpeed;
      }
    }
}
