using UnityEngine;
using UnityEngine.UI;
public class StartAnimationOnButtonPress : MonoBehaviour
{
    public Animator animator;
    public string animationTriggerName = "StartAnimation";
    void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnButtonPress);
        }
    }
    void OnButtonPress()
    {
        if (animator != null)
        {
            animator.SetTrigger(animationTriggerName);
        }
    }
}