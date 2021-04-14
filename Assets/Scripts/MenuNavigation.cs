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
        option1.color = Color.green;
        option2.color = Color.white;
        option3.color = Color.white;
        option1.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);

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
            option1.gameObject.transform.localScale = new Vector3(1, 1, 1);
            option2.gameObject.transform.localScale = new Vector3(1, 1, 1);
            option3.gameObject.transform.localScale = new Vector3(1, 1, 1);
            errorMessage.enabled = false;
            errorText.enabled = false;

            switch (selectedOption)
            {
                case 1:
                    option1.color = Color.green;
                    option1.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case 2:
                    option2.color = Color.green;
                    option2.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case 3:
                    option3.color = Color.green;
                    option3.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
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
            option1.gameObject.transform.localScale = new Vector3(1, 1, 1);
            option2.gameObject.transform.localScale = new Vector3(1, 1, 1);
            option3.gameObject.transform.localScale = new Vector3(1, 1, 1);
            errorMessage.enabled = false;
            errorText.enabled = false;

            switch (selectedOption)
            {
                case 1:
                    option1.color = Color.green;
                    option1.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case 2:
                    option2.color = Color.green;
                    option2.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
                case 3:
                    option3.color = Color.green;
                    option3.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Picked " + selectedOption);

            switch (selectedOption)
            {
                case 1:
                    Debug.Log("OPTION 1");
                    SceneManager.LoadScene("GameScene");
                    break;
                case 2:
                    Debug.Log("OPTION 2");
                    SceneManager.LoadScene("InstructionsScene");
                    break;
                case 3:
                    Debug.Log("OPTION 3");
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
        Debug.Log("Option not available");
        errorMessage.enabled = true;
        errorText.enabled = true;
    }
}
