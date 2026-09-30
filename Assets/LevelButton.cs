using TMPro;
using UnityEditor.Analytics;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelNumberText;
    [SerializeField] private GameObject[] stars;
    [SerializeField] private GameObject StarRoot;
    [SerializeField] private GameObject LockImage;

    public void Init(int lvln, int starCount, bool locked)
    {
        levelNumberText.text = $"{lvln}";
        if (locked)
        {
            LockImage.SetActive(true);
            StarRoot.SetActive(false);
        }
        else
        {

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].SetActive(i < starCount);
            }
            if (starCount == 0)
            {
                curInit();
            }
        }

    }

    public void curInit()
    {
        
        LockImage.SetActive(false);
        StarRoot.SetActive(false);
    }
}
