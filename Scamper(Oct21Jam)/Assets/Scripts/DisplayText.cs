using TMPro;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshProUGUI>().ForceMeshUpdate(true, true);
    }
}
