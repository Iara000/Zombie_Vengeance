using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject Opções;
    [SerializeField] private GameObject Sair;
    [SerializeField] private GameObject Fases;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject Hud;
    public void AbrirOpções()
    {
        Menu.SetActive(false);
        Opções.SetActive(true);
    }
    public void FecharOpções()
    {
        Menu.SetActive(true);
        Opções.SetActive(false);
    }
    public void AbrirSair()
    {
        Menu.SetActive(false);
        Sair.SetActive(true);
    }
    public void FecharSair()
    {
        Menu.SetActive(true);
        Sair.SetActive(false);
    }
    public void AbrirFases()
    {
        Menu.SetActive(false);
        Fases.SetActive(true);
    }
    public void FecharFases()
    {
        Menu.SetActive(true);
        Fases.SetActive(false);
    }
    public void Fase1()
    {
        SceneManager.LoadScene("Fase1");
    }
    public void Fase2()
    {
        SceneManager.LoadScene("Fase2");
    }
    public void Fase3()
    {
        SceneManager.LoadScene("Fase3");
    }
    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void menuPause()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    public void Pause()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        Hud.SetActive(false);
    }
    public void Unpause()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        Hud.SetActive(true);
    }
    public void SairJogo ()
    {
            UnityEditor.EditorApplication.isPlaying = false;
            //Application.Quit();
    }
}