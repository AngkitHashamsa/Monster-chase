using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIControler : MonoBehaviour
{



   public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }


   public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
 
}
