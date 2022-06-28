using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //StartMenu Buttons
    public void StartGame() //StartMenu  button
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void controlMenu() //StartMenu button
    {
        SceneManager.LoadScene("ControlsMenu");
    }

    public void ExitGame() //StartMenu button
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    //ControlsMenu Buttons
    public void ExitMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    //Win Menu
    public void WinMenu()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public void BossFight()
    {
        SceneManager.LoadScene("BossFight");
    }

    /*public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }*/

    public void StoryOne()
    {
        SceneManager.LoadScene("StoryOne");
    }

    public void LvlOne()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    
        
    
}
