using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GirlManager : MonoBehaviour
{
    public TextMeshProUGUI storyText; // Assign your TextMeshPro GUI element in the inspector
    public GameObject background;
    public GameObject chooseUI;

    public float sentenceDisplayTime = 5f; // Time in seconds each sentence is displayed
    public float timeBetweenSentences = 1f; // Time in seconds between sentences

    public AudioSource backgroundSource; // Assign in inspector
    public AudioSource dialogSource; // Assign in inspector

    public AudioClip[] dialogClip; // Assign in inspector
    // Start is called before the first frame update
    void Start()
    {
        //Camera Dark to clear reality -- Auto

        StartCoroutine(ShowStoryIntro());
    
        backgroundSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    

    }

     private IEnumerator ShowStoryIntro()
    {
        yield return new WaitForSeconds(2f); // Wait for the display time

        yield return new WaitForSeconds(sentenceDisplayTime); // Wait for the display time

        //Dialog Girl: "Have you seen a water bottle?"
        dialogSource.clip = dialogClip[0]; dialogSource.Play();     
        background.SetActive(true);
        storyText.text = "Have you seen a water bottle?";
        yield return new WaitForSeconds(5f); // Wait for the display time

        //Dialog Boy: "No, I haven't seen it. By the way, where are you from?"
        dialogSource.clip = dialogClip[1]; dialogSource.Play();
        storyText.text = "No, I haven't seen it.";
        yield return new WaitForSeconds(2f); // Wait for the display time
        storyText.text = "By the way, where are you from?";
        yield return new WaitForSeconds(5f); // Wait for the display time

        //Dialog Girl: "I am from New York."
        dialogSource.clip = dialogClip[2]; dialogSource.Play();
        storyText.text = "I am from New York.";
        yield return new WaitForSeconds(5f); // Wait for the display time

        //Dialog Boy: "Oh, I meant which part of Africa originally?"
        dialogSource.clip = dialogClip[3]; dialogSource.Play();
        storyText.text = "Oh, I meant which part of Africa originally?";
        yield return new WaitForSeconds(5f); // Wait for the display time

        //Clean text, and text background
        storyText.text = "";
        background.SetActive(false); // Clear the text

        //UI shows up
        yield return new WaitForSeconds(timeBetweenSentences); // Wait before showing the next sentence
        chooseUI.SetActive(true);
        //Dialog Voiceover: "How Do You Feel?", "Drop an emoji in the circle for his reaction."

        dialogSource.clip = dialogClip[4]; dialogSource.Play();
    }
}
