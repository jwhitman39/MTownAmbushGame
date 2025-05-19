using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GameLogic : MonoBehaviour
{
    public GameObject player;
    public GameObject monster;
    public GameObject inputDisplay;
    public GameObject progressMeter;
    public List<GameObject> buttonOptions;
    public KeyCode pressA;
    public KeyCode pressB;
    public KeyCode pressY;
    public KeyCode pressX;
    public KeyCode pressR;
    public KeyCode pressL;
    public KeyCode pressZR;
    public KeyCode pressZL;
    public KeyCode pressLS;
    public KeyCode pressRS;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // on start, create list of all the possible buttons the player could input
        CompileButtons();
        CreateInput();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateInput()
    {
        // create a 10 input string 
        for (int i = 0; i < 10; i++)
        {
            // pull a random range from the list of button options
            int index = UnityEngine.Random.Range(0, buttonOptions.Count);
            if(buttonOptions[i] != null)
            {
                GameObject chosenButton = buttonOptions[index];
                Debug.Log("the chosen button is " + chosenButton.name);
                GameObject newInput = Instantiate(chosenButton, new Vector3(inputDisplay.transform.position.x,
                                                                            inputDisplay.transform.position.y,
                                                                            inputDisplay.transform.position.z),
                                                                            inputDisplay.transform.rotation);
                return;
            }
            else
            {
                Debug.Log("Couldn't find buttons??");
                return;
            }
        }
    }
    public void CompileButtons()
    {
        // find all buttons by tag and add them to the button options list
        buttonOptions.AddRange(GameObject.FindGameObjectsWithTag("Button"));
        return;
    }
}
