using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PauseButton : MonoBehaviour
{
    private bool isPaused = false;
    [SerializeField] private GameObject PauseMenu;
    public void Pause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 0;
            PauseMenu.SetActive(true);
        }
    }
    public void Unpause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            Time.timeScale = 1;
            PauseMenu.SetActive(false);
        }
    }
}