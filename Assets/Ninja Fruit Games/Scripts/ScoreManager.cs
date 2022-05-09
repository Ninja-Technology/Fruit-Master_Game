using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    public int currentScore; 
    public int highScore;

    [Header("UI Fields")]
    public TextMeshProUGUI hightScoreText;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI finalScoreText;



    public static ScoreManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        // DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore",0);
        hightScoreText.text = highScore.ToString();

        //Set the current score as 0.
        currentScoreText.text = "0";

    }


    public void AddScore(int scorePoint)
    {
        currentScore = currentScore + scorePoint;
        PlayerPrefs.SetInt("CurrentScore",currentScore);

        
        //Display the current score in UI
        currentScoreText.text = currentScore.ToString();

        //Also, update the final score
        finalScoreText.text = currentScore.ToString();

        //play a crowd suspense sound if user gets a 100 points
        if (currentScore == 100 )
        {
            AudioManager.instance.kidsCheering.gameObject.transform.position = transform.position;
            AudioManager.instance.kidsCheering.Play();

            AudioManager.instance.OneHundredPoint.gameObject.transform.position = transform.position;
            AudioManager.instance.OneHundredPoint.Play();
        }

        //play a crowd surprise sound if user get a 200 points
        if(currentScore == 200)
        {
            AudioManager.instance.kidsCheering.gameObject.transform.position = transform.position;
            AudioManager.instance.kidsCheering.Play();

            AudioManager.instance.TwoHundredPoint.gameObject.transform.position = transform.position;
            AudioManager.instance.TwoHundredPoint.Play();
        }

        //play a crowd surprise sound if user get a 300 points
        if (currentScore == 300)
        {
            AudioManager.instance.kidsCheering.gameObject.transform.position = transform.position;
            AudioManager.instance.kidsCheering.Play();

            AudioManager.instance.ThreeHundredPoint.gameObject.transform.position = transform.position;
            AudioManager.instance.ThreeHundredPoint.Play();
        }

        //play a crowd surprise sound if user get a 400 points
        if (currentScore == 400)
        {
            AudioManager.instance.kidsCheering.gameObject.transform.position = transform.position;
            AudioManager.instance.kidsCheering.Play();

            AudioManager.instance.FourHundredPoint.gameObject.transform.position = transform.position;
            AudioManager.instance.FourHundredPoint.Play();
        }

        //play a crowd surprise sound if user get a 500 points
        if (currentScore == 500)
        {
            AudioManager.instance.kidsCheering.gameObject.transform.position = transform.position;
            AudioManager.instance.kidsCheering.Play();

            AudioManager.instance.FiveHundredPoint.gameObject.transform.position = transform.position;
            AudioManager.instance.FiveHundredPoint.Play();
        }

 
        //-----------------------------------------------------------------------
        if (currentScore > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore",currentScore);
            hightScoreText.text = currentScore.ToString();

        }
    }
}
