using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuyPOVPortal : MonoBehaviour
{
    public GameObject happyBall;
    public GameObject sadBall;
    public GameObject madBall;
   // public Animator guyAnim;
    public Animator girlAnim;
    // Start is called before the first frame update
    void Start()
    {
      girlAnim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

            private void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject that collided with this one has the tag "Player"
        if (other.gameObject.CompareTag("HappyBall"))
        {

            //  anim.SetBool("isHappy", true);
            //  anim.SetBool("isSad", false);
            //  anim.SetBool("isMad", false);
            girlAnim.Play("Happy");
        }

        if (other.gameObject.CompareTag("SadBall"))
        {

            //  anim.SetBool("isSad", true);
            //  anim.SetBool("isHappy", false);
            //  anim.SetBool("isMad", false);
             girlAnim.Play("Sad");
        }

        if (other.gameObject.CompareTag("MadBall"))
        {

            //  anim.SetBool("isMad", true);
            //  anim.SetBool("isSad", false);
            //  anim.SetBool("isHappy", false);
             girlAnim.Play("Mad");
        }
    }
}
