using UnityEngine;
using UnityEngine.UI;

public class PushbackBarUI : MonoBehaviour
{
    public float Pushback, MaxPushback, Width, Height;
    [SerializeField]
    private RectTransform pushbackBar;

    public void SetMaxPushback(float maxPushback)
    {
        MaxPushback = maxPushback;
    }
    public void SetPushback(float pushback)
    {
        Pushback = pushback;
        float newHeight = (Pushback / MaxPushback) * Height;
        pushbackBar.sizeDelta = new Vector2(Width, newHeight);
    }
}
