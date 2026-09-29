using UnityEngine;

public class LevelMenuGenerator : MonoBehaviour
{
    [SerializeField] private int lvlcount;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform root;
    private void Awake()
    {
        ClearRoot();
        LevelBtnGen();
    }
    private void LevelBtnGen()
    {
        for (int i = 0; i < lvlcount; i++)
        {
            Instantiate(buttonPrefab, root);
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
