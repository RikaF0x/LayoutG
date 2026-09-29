using TMPro;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelNumberText;
    public void Init(int lvln)
    {
        levelNumberText.text = $"{lvln}";
    }
}
