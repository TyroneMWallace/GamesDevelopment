//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Once the gameOver method is called, gameOver is currently false 
    //EndGame function is then set to True, prompting the restart method
    bool gameOver = false;

    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        //if the game has ended call this function
        if (gameOver == false)
        {
            //Endgame
            gameOver = true;
            //Debug.Log("EndGame");
            // Creates a delay between restarts
            Invoke("Restart", 2f);
        }
    }

    void Restart ()
    {
        //Load the scene with the given name and return the name of the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
