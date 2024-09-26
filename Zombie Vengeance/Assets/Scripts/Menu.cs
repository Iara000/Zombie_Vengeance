using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] private string LevelJogo;
    [SerializeField] private GameObject painelMenuIcinial;
    [SerializeField] private GameObject painelOpções;
    public void Jogar()
    {
        SceneManager.LoadScene(LevelJogo);
    }
    public void AbrirOpções()
    {
        painelMenuIcinial.SetActive(false);
        painelOpções.SetActive(true);
    }
    public void FecharOpções()
    {
        painelMenuIcinial.SetActive(true);
        painelOpções.SetActive(false);
    }
}