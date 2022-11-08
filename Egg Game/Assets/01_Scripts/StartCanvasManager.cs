using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [Header("Strings to put in the textboxes")]
    public string GameTitle = "Egg Game";
    public string PlayButtonText = "Play Game";
    public string QuitButtonText = "Quit Game";
    [Space(10)]

    [Header("Textbox References")]
    public Text TitleTextbox;
    public Text PlayButtonTextbox;
    public Text QuitButtonTextbox;
    [Space(20)]

    [SerializeField]
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        TitleTextbox.text = GameTitle;
        PlayButtonTextbox.text = PlayButtonText;
        QuitButtonTextbox.text = QuitButtonText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Called when the play button is pressed
    public void StartGame()
    {
        //gm.StartGame();
    }

    public void QuitGame()
    {
        //gm.QuitGame();
    }
}
