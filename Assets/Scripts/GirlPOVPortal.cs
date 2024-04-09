using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlPOVPortal : MonoBehaviour
{

    public GameObject happyBall;
    public GameObject sadBall;
    public GameObject madBall;
    public Animator guyAnim;
    public Animator girlAnim;
    // Start is called before the first frame update
    void Start()
    {
      guyAnim.Play("Idle");
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
             happyBall.SetActive(true);
             sadBall.SetActive(false);
             madBall.SetActive(false);
            //  anim.SetBool("isHappy", true);
            //  anim.SetBool("isSad", false);
            //  anim.SetBool("isMad", false);
            guyAnim.Play("Idle");
        }

        if (other.gameObject.CompareTag("SadBall"))
        {
             happyBall.SetActive(false);
             sadBall.SetActive(true);
             madBall.SetActive(false);
            //  anim.SetBool("isSad", true);
            //  anim.SetBool("isHappy", false);
            //  anim.SetBool("isMad", false);
             guyAnim.Play("Idle");
        }

        if (other.gameObject.CompareTag("MadBall"))
        {
             happyBall.SetActive(false);
             sadBall.SetActive(false);
             madBall.SetActive(true);
            //  anim.SetBool("isMad", true);
            //  anim.SetBool("isSad", false);
            //  anim.SetBool("isHappy", false);
             guyAnim.Play("Idle");
        }
    }

}
