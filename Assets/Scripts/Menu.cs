using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  private Button startButton;
  private Button exitButton;
  private Button optionsButton;
  private Button aboutButton;
  // private MeshRenderer aboutMesh;
  // private string aboutText {get{return "dev::briantsai...thanksforplaying";}}

  void Awake()
  {
    startButton = GameObject.Find("StartButton").GetComponent<Button>();
    exitButton = GameObject.Find("ExitButton").GetComponent<Button>();
    optionsButton = GameObject.Find("OptionsButton").GetComponent<Button>();
    aboutButton = GameObject.Find("AboutButton").GetComponent<Button>();
    // aboutMesh = GameObject.Find("AboutText").GetComponent<MeshRenderer>();
  }

  void Start()
  {
    startButton.onClick.AddListener(startGame);
    exitButton.onClick.AddListener(exitApp);
    optionsButton.onClick.AddListener(customizeOptions);
    // aboutButton.onClick.AddListener(displayAbout);
    //should also add loadsavedata call
  }

  //starts game when startButton is clicked
  private void startGame()
  {
    //load scene with actual game
    //eventually make the game scene load asynchronously with a load screen
    //https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadSceneAsync.html
    SceneManager.LoadScene("Game");
  }

  //exits app when exitButton is clicked
  private void exitApp()
  {
    //save persistent data
    //working on that
    //for editor, use below for exiting
    UnityEditor.EditorApplication.isPlaying = false;
    //for build, use below for exiting
    // Application.Quit();
  }

  //opens options menu when optionsButton is clicked
  private void customizeOptions()
  {
    //be sure to set these values in playerpref
    Debug.Log("you aren't anyones' 'option' gurl");
  }

  //display about page when aboutButton is clicked
  private void displayAbout()
  {
    //give the player some brian bio
    Debug.Log("do you have some time to learn about brian");
  }

  //make a new class for handling persistent data? yes pls
  private void loadSaveData()
  {}
}
