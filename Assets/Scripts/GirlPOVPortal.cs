using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GirlPOVPortal : MonoBehaviour
{
    public TextMeshProUGUI storyText; // Assign your TextMeshPro GUI element in the inspector
    public GameObject background;
    public GameObject chooseUI;

    public AudioSource dialogSource; // Assign in inspector

    public AudioClip[] dialogClip; // Assign in inspector
    // Start is called before the first frame update

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
        //if "HappyBall" is selected, play the Dialog
             // Girl: "My grandparents were originally from Kenya, but I was born and raised in the United States."
            //  Boy: "I traveled to Africa last summer, and Kenya was my favorite country. The safaris are amazing. You remind me of the people I met in Kenya, so I was curious if you had roots there."

        
       //if "SadBall" is selected, play the Dialog
             // Girl: "I was born in the United States, not in Africa."
            //  Boy: "Sorry! I took a trip to Africa, and something about you reminds me of the people I met there."


       //if "MadBall" is selected, play the Dialog
             // Girl: "Not every black person is from Africa. Please, let's respect each other's privacy."
            //  Boy: "I am sorry. It wasn't my intention. Never mind. You are too sensitive."        
    }

        private void OnTriggerEnter(Collider other)
    {

        // Check if the GameObject that collided with this one has the tag "Player"
        if (other.gameObject.CompareTag("HappyBall"))
        {

            guyAnim.Play("Happy");
            StartCoroutine(Happy());

        }

        if (other.gameObject.CompareTag("SadBall"))
        {
            //Choose UI Disappear
             guyAnim.Play("Sad");
             StartCoroutine(Sad());
            // Girl: "I was born in the United States, not in Africa."
            //  Boy: "Sorry! I took a trip to Africa, and something about you reminds me of the people I met there."
            //Choose UI Appear
        }

        if (other.gameObject.CompareTag("MadBall"))
        {
            //Choose UI Disappear
             guyAnim.Play("Mad");
             StartCoroutine(Mad());
            // Girl: "Not every black people is from Africa. Please, be respect."
            //  Boy: "I am sorry. It wasn't my intention. Never mind. You are too sensitive."
            //Choose UI Appear       
        }
    }

         private IEnumerator Happy()
    {
        yield return new WaitForSeconds(2f); // Wait for the display time

        //Choose UI Disappear
        chooseUI.SetActive(false);
        // Girl: "My grandparents were originally from Kenya, but I was born and raised in the United States."
        background.SetActive(true);
        dialogSource.clip = dialogClip[0]; dialogSource.Play();     
        storyText.text = "My grandparents were originally from Kenya";
        yield return new WaitForSeconds(5f); // Wait for the display time
        dialogSource.clip = dialogClip[1]; dialogSource.Play();     
        storyText.text = "but I was born and raised in the United States";
        yield return new WaitForSeconds(5f); // Wait for the display time
        //  Boy: "I traveled to Africa last summer, and Kenya was my favorite country. The safaris are amazing. You remind me of the people I met in Kenya, so I was curious if you had roots there."
        dialogSource.clip = dialogClip[2]; dialogSource.Play();     
        storyText.text = "I traveled to Africa last summer";
        yield return new WaitForSeconds(5f); // Wait for the display time
        dialogSource.clip = dialogClip[3]; dialogSource.Play();     
        storyText.text = "Kenya was my favorite country";
        yield return new WaitForSeconds(5f); // Wait for the display time
        dialogSource.clip = dialogClip[4]; dialogSource.Play();     
        storyText.text = "The safaris are amazing";
        yield return new WaitForSeconds(5f); // Wait for the display time
        dialogSource.clip = dialogClip[5]; dialogSource.Play();     
        storyText.text = "You remind me of the people I met in Kenya";
        yield return new WaitForSeconds(5f); // Wait for the display time
        dialogSource.clip = dialogClip[6]; dialogSource.Play();     
        storyText.text = "so I was curious if you had roots there";
        yield return new WaitForSeconds(5f); // Wait for the display time
        //Clean text, and text background
        storyText.text = "";
        background.SetActive(false); // Clear the text
        //Choose UI Appear
        chooseUI.SetActive(true);
    }

        private IEnumerator Sad()
    {
        yield return new WaitForSeconds(2f); // Wait for the display time

        //Choose UI Disappear
        chooseUI.SetActive(false);
        // Girl: "I was born in the United States, not in Africa."
        background.SetActive(true);
        dialogSource.clip = dialogClip[7]; dialogSource.Play();     
        storyText.text = "I was born in the United States";
        yield return new WaitForSeconds(2f); // Wait for the display time
        dialogSource.clip = dialogClip[8]; dialogSource.Play();    
        storyText.text = "not in Africa";
        yield return new WaitForSeconds(5f); // Wait for the display time
        //  Boy: "Sorry! I took a trip to Africa, and something about you reminds me of the people I met there."
        dialogSource.clip = dialogClip[9]; dialogSource.Play();      
        storyText.text = "Sorry! I took a trip to Africa";
        yield return new WaitForSeconds(2f); // Wait for the display time
        dialogSource.clip = dialogClip[10]; dialogSource.Play(); 
        storyText.text = "and something about you reminds me of the people I met there";
        yield return new WaitForSeconds(5f); // Wait for the display time
        //Clean text, and text background
        storyText.text = "";
        background.SetActive(false); // Clear the text
        //Choose UI Appear
        chooseUI.SetActive(true);
    }

    private IEnumerator Mad()
    {
        yield return new WaitForSeconds(2f); // Wait for the display time

        //Choose UI Disappear
        chooseUI.SetActive(false);
        // Girl: "Not every black person is from Africa. Please, be respectful."
        dialogSource.clip = dialogClip[11]; dialogSource.Play();     
        background.SetActive(true);
        storyText.text = "Not every black person is from Africa";
        yield return new WaitForSeconds(3f); // Wait for the display time
        dialogSource.clip = dialogClip[12]; dialogSource.Play();     
        storyText.text = "Please, be respectful";
        yield return new WaitForSeconds(5f); // Wait for the display time
        //  Boy: "I am sorry. It wasn't my intention. Never mind. You are too sensitive."
        dialogSource.clip = dialogClip[13]; dialogSource.Play();     
        storyText.text = "I am sorry";
        yield return new WaitForSeconds(2f); // Wait for the display time
        dialogSource.clip = dialogClip[14]; dialogSource.Play(); 
        storyText.text = "It wasn't my intention";
        yield return new WaitForSeconds(2f); // Wait for the display time
        dialogSource.clip = dialogClip[15]; dialogSource.Play(); 
        storyText.text = "Never mind. You are too sensitive";
        yield return new WaitForSeconds(5f); // Wait for the display time
        //Clean text, and text background
        storyText.text = "";
        background.SetActive(false); // Clear the text
        //Choose UI Appear
        chooseUI.SetActive(true);
    }

}
