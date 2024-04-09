using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePortal : MonoBehaviour
{
    public GameObject whiteGuy;
    public GameObject blackGirl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        // Check if the GameObject that collided with this one has the tag "BlackGirl"
        if (other.gameObject.CompareTag("BlackGirl"))
        {
            SceneManager.LoadScene("GirlPOV");
        }

                // Check if the GameObject that collided with this one has the tag "BlackGirl"
        if (other.gameObject.CompareTag("WhiteGuy"))
        {
            SceneManager.LoadScene("GuyPOV");
        }



    }   
}
