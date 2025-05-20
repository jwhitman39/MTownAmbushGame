using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.InputSystem;
using Unity.VisualScripting;
using UnityEngine.WSA;
using System.Collections;

public class GameLogic : MonoBehaviour
{
    // MAIN ASSETS
    public GameObject player;
    public GameObject monster;
    public GameObject inputDisplay;
    public GameObject progressMeter;
    public GameObject chosenButton;
    // ANIMATION ASSETS
    public List<GameObject> buttonOptions;
    public float buttonIndicator;
    public float requiredButton = 0;
    public float attemptedButton = 0;
    public bool isPressed = false;
    Animator animator;
    PlayerControls controls;
    Player PlayerLogic = null;

    private void Awake()
    {
        PlayerLogic = player.GetComponent<Player>(); 
        controls = new PlayerControls();
        controls.Gameplay.PressA.performed += ctx => PressA();
        controls.Gameplay.PressB.performed += ctx => PressB();
        controls.Gameplay.PressY.performed += ctx => PressY();
        controls.Gameplay.PressX.performed += ctx => PressX();
        controls.Gameplay.PressL.performed += ctx => PressL();
        controls.Gameplay.PressR.performed += ctx => PressR();
        controls.Gameplay.PressZL.performed += ctx => PressZL();
        controls.Gameplay.PressZR.performed += ctx => PressZR();
        controls.Gameplay.PressLS.performed += ctx => PressLS();
        controls.Gameplay.PressRS.performed += ctx => PressRS();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator= inputDisplay.GetComponent<Animator>();
        PlayerLogic.SetHealth(100);
        PlayerLogic.SetPushback(0);
        // on start, create list of all the possible buttons the player could input
        CompileButtons();
        CreateInput();
        StartCoroutine(DecayHealth(2f));
    }

    // Update is called once per frame
    void Update()
    {
        ConfirmButtons();
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
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
                chosenButton = buttonOptions[index];
                Debug.Log("the chosen button is " + chosenButton.name);
                GameObject newInput = Instantiate(chosenButton, new Vector3(inputDisplay.transform.position.x,
                                                                            inputDisplay.transform.position.y,
                                                                            inputDisplay.transform.position.z),
                                                                            inputDisplay.transform.rotation);
                // CODE FOR SETTING ANIMATION FLOAT
                if (chosenButton.name == "AButton")
                {
                    animator.SetFloat("ButtonIndicator", 1);
                    requiredButton = 1;
                    return;
                }
                if (chosenButton.name == "BButton")
                {
                    animator.SetFloat("ButtonIndicator", 2);
                    requiredButton = 2;
                    return;
                }
                if (chosenButton.name == "YButton")
                {
                    animator.SetFloat("ButtonIndicator", 3);
                    requiredButton = 3;
                    return;
                }
                if (chosenButton.name == "XButton")
                {
                    animator.SetFloat("ButtonIndicator", 4);
                    requiredButton = 4;
                    return;
                }
                if (chosenButton.name == "LButton")
                {
                    animator.SetFloat("ButtonIndicator", 5);
                    requiredButton = 5;
                    return;
                }
                if (chosenButton.name == "RButton")
                {
                    animator.SetFloat("ButtonIndicator", 6);
                    requiredButton = 6;
                    return;
                }
                if (chosenButton.name == "ZLButton")
                {
                    animator.SetFloat("ButtonIndicator", 7);
                    requiredButton = 7;
                    return;
                }
                if (chosenButton.name == "ZRButton")
                {
                    animator.SetFloat("ButtonIndicator", 8);
                    requiredButton = 8;
                    return;
                }
                if (chosenButton.name == "LSButton")
                {
                    animator.SetFloat("ButtonIndicator", 9);
                    requiredButton = 9;
                    return;
                }
                if (chosenButton.name == "RSButton")
                {
                    animator.SetFloat("ButtonIndicator", 10);
                    requiredButton = 10;
                    return;
                }
            }
            else
            {
                Debug.Log("Couldn't find buttons??");
                return;
            }
        }
    }
    void PressA()
    {
        isPressed = true;
        attemptedButton = 1;
        Debug.Log("pressed A! The float you sent was " + attemptedButton);
    }
    void PressB()
    {
        isPressed = true;
        attemptedButton = 2;
        Debug.Log("pressed B! The float you sent was " + attemptedButton);
    }
    void PressY()
    {
        isPressed = true;
        attemptedButton = 3;
        Debug.Log("pressed Y! The float you sent was " + attemptedButton);
    }
    void PressX()
    {
        isPressed = true;
        attemptedButton = 4;
        Debug.Log("pressed X! The float you sent was " + attemptedButton);
    }
    void PressL()
    {
        isPressed = true;
        attemptedButton = 5;
        Debug.Log("pressed L! The float you sent was " + attemptedButton);
    }
    void PressR()
    {
        isPressed = true;
        attemptedButton = 6;
        Debug.Log("pressed R! The float you sent was " + attemptedButton);
    }
    void PressZL()
    {
        isPressed = true;
        attemptedButton = 7;
        Debug.Log("pressed ZL! The float you sent was " + attemptedButton);
    }
    void PressZR()
    {
        isPressed = true;
        attemptedButton = 8;
        Debug.Log("pressed ZR! The float you sent was " + attemptedButton);
    }
    void PressLS()
    {
        isPressed = true;
        attemptedButton = 9;
        Debug.Log("pressed LS! The float you sent was " + attemptedButton);
    }
    void PressRS()
    {
        isPressed = true;
        attemptedButton = 10;
        Debug.Log("pressed RS! The float you sent was " + attemptedButton);
    }
    public void CompileButtons()
    {
        // find all buttons by tag and add them to the button options list
        buttonOptions.AddRange(GameObject.FindGameObjectsWithTag("Button"));
        return;
    }
    public void ConfirmButtons()
    {
        if (isPressed)
        {
            // if the required button is the same as the attempted button...
            if (attemptedButton == requiredButton)
            {
                Debug.Log("button " + chosenButton.name + " was chosen and " + chosenButton.name + " was pressed.");
                // write code here for pushing the progress meter forward...
                PlayerLogic.SetPushback(+10);
                // tell the computer that the button is done being pressed
                isPressed = false;
                // run the CreateInput function again
                CreateInput();
                return;
            }
            // if the attempted button is different from the required button...
            if (attemptedButton != requiredButton) 
            {
                Debug.Log("wrong button. oops!");
                // write code here for pushing the progress meter backward...
                PlayerLogic.SetPushback(-10);
                isPressed = false;
                //run the CreateInput function again
                CreateInput();
                return;
            }
        }
    }
    public IEnumerator DecayHealth(float delay)
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(delay);
            PlayerLogic.SetHealth(-10);
        }
    }
}
