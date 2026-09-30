using Unity.VisualScripting;
using UnityEngine;

public class LevelMenuGenerator : MonoBehaviour
{
    [SerializeField] private int lvlcount;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform root;
    [SerializeField] private int[] lvlStars;
    [SerializeField] private int OpenlvlCount;
    private void Awake()
    {
        ClearRoot();
        LevelBtnGen();
    }
    private void LevelBtnGen()
    {
        for (int i = 0; i < lvlcount; i++)
        {
            var ins = Instantiate(buttonPrefab, root);
            if (ins.TryGetComponent(out LevelButton btn))
            {
                if (i <= OpenlvlCount)
                {
                    btn.Init(i + 1, lvlStars[i], false);
                }
                else
                {
                    btn.Init(i + 1, 0, true);
                }
            }
        }
        
    }
    private void ClearRoot()
    {
        for (int i = 0; i < root.childCount; i++)
        {
            Destroy(root.GetChild(i).gameObject);
        }
    }

}
