using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TransitionBunnot : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Button btn;
    [SerializeField] private GameObject currS;
    [SerializeField] private GameObject nextS;

    private void Awake()
    {
        btn.onClick.AddListener(DoTransition);
    }
    private void DoTransition()
    {
        currS.SetActive(false);
        nextS.SetActive(true);
    }
    
    private void OnDestroy()
    {
        btn.onClick.RemoveListener(DoTransition);
    }
}
