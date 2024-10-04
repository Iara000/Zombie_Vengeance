using UnityEngine;
using UnityEngine.SceneManagement;
public class FasesMenu : MonoBehaviour
{
    [SerializeField] private string LevelJogo;
    [SerializeField] private GameObject painelMenuIcinial;
    public void Jogar()
    {
        SceneManager.LoadScene(LevelJogo);
    }
}