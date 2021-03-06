using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class LobbyMenu : MonoBehaviour
{

    public Material greenMat;

    public GameObject timeCountDownCanvas;
    public TextMeshProUGUI timeText;
    public float smooth = 0.1f;

    public GameObject menuCanvas;
    public GameObject creditCanvas;
    public GameObject instructionCanvas;

    //----------------------------------------------------------------------------------------------------------------------------------


    void Start()
    {

        timeCountDownCanvas.SetActive(false); //hide countdown UI on start
        creditCanvas.SetActive(false); //hide credit UI on start
        instructionCanvas.SetActive(false); //hide instructions UI on start

        //Playing lobby background sound
        AudioManager.instance.lobbyAudio.gameObject.transform.position = transform.position;
        AudioManager.instance.lobbyAudio.Play();

    }


    //click button actions

    public void OnGameStartClicked()
    {
        //Playing click button sound effect
        AudioManager.instance.buttonClickSound.gameObject.transform.position = transform.position;
        AudioManager.instance.buttonClickSound.Play();

        ////Playing Sound for count down
        AudioManager.instance.countDownVoice.gameObject.transform.position = transform.position;
        AudioManager.instance.countDownVoice.Play();

        //   menuCanvas.SetActive(false); //hide main menu screen
       

        //Start the game
        StartCoroutine(StartGame(10));


    }


    public void OnInstructionClicked()
    {
        //Playing click button sound effect
        AudioManager.instance.buttonClickSound.gameObject.transform.position = transform.position;
        AudioManager.instance.buttonClickSound.Play();

        ////Pause Lobby background sound
        AudioManager.instance.lobbyAudio.gameObject.transform.position = transform.position;
        AudioManager.instance.lobbyAudio.Pause();

        creditCanvas.SetActive(false); //set credit screen to true 
        menuCanvas.SetActive(false); //hide main menu screen
        instructionCanvas.SetActive(true); //set to show instructions screen

    }
    public void OnCreditsClicked()
    {
        //Playing click button sound effect
        AudioManager.instance.buttonClickSound.gameObject.transform.position = transform.position;
        AudioManager.instance.buttonClickSound.Play();

        ////Pause Lobby background sound
        AudioManager.instance.lobbyAudio.gameObject.transform.position = transform.position;
        AudioManager.instance.lobbyAudio.Pause();

        menuCanvas.SetActive(false); //hide main menu screen
        instructionCanvas.SetActive(false); //hide instructions screen
        creditCanvas.SetActive(true); //set credit screen to true


        GetComponent<Animation>()["Credit"].wrapMode = WrapMode.Once;
        GetComponent<Animation>().Play("Credit");

    }
    public void OnQuitClicked()
    {
        //Playing click button sound effect
        AudioManager.instance.buttonClickSound.gameObject.transform.position = transform.position;
        AudioManager.instance.buttonClickSound.Play();

        Application.Quit(); //quits the application

    }

    public void OnBackClicked()
    {
        //Playing click button sound effect
        AudioManager.instance.buttonClickSound.gameObject.transform.position = transform.position;
        AudioManager.instance.buttonClickSound.Play();

        //Playing lobby background sound
        AudioManager.instance.lobbyAudio.gameObject.transform.position = transform.position;
        AudioManager.instance.lobbyAudio.Play();

        creditCanvas.SetActive(false); //set credit screen to true 
        menuCanvas.SetActive(true); //hide main menu screen
        instructionCanvas.SetActive(false); //hide instructions screen
    }



    // start game function
    IEnumerator StartGame(float countDownValue)
    {
        timeText.text = countDownValue.ToString();
        timeCountDownCanvas.SetActive(true);

        while (countDownValue > 0)
        {

            yield return new WaitForSeconds(1.0f);
            countDownValue -= 1;

            timeText.text = countDownValue.ToString();

        }
        //Load Scene
        SceneLoader.instance.LoadScene("rpgpp_lt_scene_1.0");

    }
}
