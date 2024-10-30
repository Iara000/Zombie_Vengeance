using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{


    Animator animator;
    [SerializeField] private string LevelJogo;
    [SerializeField] private GameObject painelMenuIcinial;
    [SerializeField] private GameObject painelOpções;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Jogar()
    {
        Invoke("LoadScene", 2f);
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
    private void LoadScene()
    {
        SceneManager.LoadScene(LevelJogo);
    }
    public void SairJogo ()
    {
        PlayerPrefs.DeleteAll();

    }

}