using UnityEngine;
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