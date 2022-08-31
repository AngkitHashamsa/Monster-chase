using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private string GAMPLAY_SCENE = "Gameplay";

   public void PlayGame()
    {
        int selectedPlayer = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedPlayer;

        SceneManager.LoadScene(GAMPLAY_SCENE);
    }
}// class
