using UnityEngine;
using UnityEngine.UI;
public class SomScroll : MonoBehaviour
{
    [SerializeField] private Scrollbar volumeScrollbar;
    private void Start()
    {
        volumeScrollbar.value = AudioListener.volume;
        volumeScrollbar.onValueChanged.AddListener(SetVolume);
    }
    private void SetVolume(float value)
    {
        AudioListener.volume = value;
        Debug.Log($"Volume ajustado para: {value}");
    }
    private void OnDestroy()
    {
        volumeScrollbar.onValueChanged.RemoveListener(SetVolume);
    }
}