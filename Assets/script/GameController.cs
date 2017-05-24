using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    
    public static GameController _instance;

    public int framecount= 0;

    public Text framecountText;

    public bool isGamePause = false;
    public bool isGameEnd = false;

    void Start()
    {
        Screen.SetResolution(480, 800, false);
        Time.timeScale = 1;
    }

    void Awake()
    {
        _instance = this;
    }
	
	// Update is called once per frame

    void FixedUpdate()
    {
        if (!isGameEnd)
        {
            if (!isGamePause)
            {
                framecount += 1;
            }
        }
    }
       
	void Update () {
        if (framecount>= 4700)
        {
            pauseGame();
            gameover._instance.words.text = "YOU WIN!";
            gameover._instance.sentence.text = "magnet:?xt=urn:btih:53136051687FA1539E3E497EE396E88AE266E2EF";
            gameover._instance.show();
            isGameEnd = true;
        }

        if (!isGameEnd)
        {
            framecountText.text = framecount + "";

            if (isGamePause)
            {
                this.GetComponent<AudioSource>().pitch = 0;
            }
            else if (!isGamePause)
            {
                this.GetComponent<AudioSource>().pitch = 1;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                print(framecount);
            }


            if (Input.GetKeyDown(KeyCode.W))
            {
                if (!isGamePause)
                {
                    pauseGame();
                }
                else if (isGamePause)
                {
                    continueGame();
                }
            }
        }
        else
        {
            pauseGame();
            gameover._instance.show();
        }
	}


    public void pauseGame()
    {
        Time.timeScale = 0;
        isGamePause = true;
    }

    public void continueGame()
    {
        Time.timeScale = 1;
        isGamePause = false;
    }

    public void endGame()
    {
        isGameEnd = true;
    }
}
