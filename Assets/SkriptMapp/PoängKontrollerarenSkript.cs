using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PoängKontrollerarenSkript : MonoBehaviour
{
    public TextMeshProUGUI PoängText;
    public int PoängMängd;
    private void Update()
    {
        PoängText.text = string.Format("Poäng: {0}", PoängMängd);
    }
}
