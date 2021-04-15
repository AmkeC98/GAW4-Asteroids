using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{
    public Text option1;
    public Text option2;
    public Text option3;
    public Image errorMessage;
    public Text errorText;

    private int numberOfOptions = 3;
    private int selectedOption;

    private void Start()
    {
        selectedOption = 1;
        option1.color = Color.grey;
        option2.color = Color.white;
        option3.color = Color.white;
        option1.fontSize = 18;

        errorMessage.enabled = false;
        errorText.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            selectedOption += 1;
            if (selectedOption > numberOfOptions)
            {
                selectedOption = 1;
            }

            option1.color = Color.white;
            option2.color = Color.white;
            option3.color = Color.white;
            option1.fontSize = 16;
            option2.fontSize = 16;
            option3.fontSize = 16;
            errorMessage.enabled = false;
            errorText.enabled = false;

            switch (selectedOption)
            {
                case 1:
                    option1.fontSize = 18;
                    option1.color = Color.grey;
                    break;
                case 2:
                    option2.fontSize = 18;
                    option2.color = Color.grey;
                    break;
                case 3:
                    option3.fontSize = 18;
                    option3.color = Color.grey;
                    break;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            selectedOption -= 1;
            if (selectedOption < 1)
            {
                selectedOption = numberOfOptions;
            }

            option1.color = Color.white;
            option2.color = Color.white;
            option3.color = Color.white;
            option1.fontSize = 16;
            option2.fontSize = 16;
            option3.fontSize = 16;
            errorMessage.enabled = false;
            errorText.enabled = false;

            switch (selectedOption)
            {
                case 1:
                    option1.fontSize = 18;
                    option1.color = Color.grey;
                    break;
                case 2:
                    option2.fontSize = 18;
                    option2.color = Color.grey;
                    break;
                case 3:
                    option3.fontSize = 18;
                    option3.color = Color.grey;
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            switch (selectedOption)
            {
                case 1:
                    SceneManager.LoadScene("GameScene");
                    break;
                case 2:
                    SceneManager.LoadScene("InstructionsScene");
                    break;
                case 3:
                    ShowError();
                    break;
            }
        }

        if (errorMessage.enabled == true && Input.GetKeyDown(KeyCode.Space))
        {
            errorMessage.enabled = false;
            errorText.enabled = false;
        }
    }

    private void ShowError()
    {
        errorMessage.enabled = true;
        errorText.enabled = true;
    }
}
