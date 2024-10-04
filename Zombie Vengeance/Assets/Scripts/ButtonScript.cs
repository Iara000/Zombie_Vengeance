using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonClickHandler : MonoBehaviour
{
    [SerializeField] private string Level;
    public Button myButton;
    void Start()
    {
        if (myButton != null)
        {
            myButton.onClick.AddListener(OnButtonClick);
        }
    }
    void OnButtonClick()
    {
        SceneManager.LoadScene(Level);
    }
}