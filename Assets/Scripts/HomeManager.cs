using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HomeManager : MonoBehaviour
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
        //Camera darken
       // Camera.main.backgroundColor = new Color(0, 0, 0, 0.7f);       
        // Voiceover + Description Show "This is an empathy-driven role-play game. After attending a reading event, Jessica realized she left her water bottle behind. Now, she's returning to the venue to search for her bottle."
        StartCoroutine(ShowStoryIntro());
        //Camera back
        // Women says "Hi, have you seem a pink waterbottle?"
        //Men says "No. By the way, where are you from?"
        //Camera darken
        //The UI shows up
                // Optionally, auto-play the audio at the start
        // PlayAudio();
        backgroundSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private IEnumerator ShowStoryIntro()
    {
        yield return new WaitForSeconds(2f); // Wait for the display time
        dialogSource.clip = dialogClip[0]; dialogSource.Play();
        storyText.text = "This is an empathy-driven role-play game";

        background.SetActive(true);

        yield return new WaitForSeconds(sentenceDisplayTime); // Wait for the display time
       // storyText.text = ""; // Clear the text
       // yield return new WaitForSeconds(timeBetweenSentences); // Wait before showing the next sentence
        dialogSource.clip = dialogClip[1]; dialogSource.Play();
        storyText.text = "After attending a reading event";
        yield return new WaitForSeconds(2f); // Wait for the display time
        storyText.text = "Jessica realized she left her water bottle behind";
        yield return new WaitForSeconds(sentenceDisplayTime); // Wait for the display time
       // storyText.text = ""; // Clear the text
        yield return new WaitForSeconds(timeBetweenSentences); // Wait before showing the next sentence
        dialogSource.clip = dialogClip[2]; dialogSource.Play();
        storyText.text = "Now, she's returning to the venue to search for her bottle";
        yield return new WaitForSeconds(sentenceDisplayTime); // Wait for the display time
        storyText.text = "";
        background.SetActive(false); // Clear the text
        yield return new WaitForSeconds(timeBetweenSentences); // Wait before showing the next sentence
        dialogSource.clip = dialogClip[3]; dialogSource.Play();
        chooseUI.SetActive(true);
        
        // Optionally, do something here after all sentences are shown (like loading a new scene)
    }

}
