using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public int treasureCollected = 0;
    [SerializeField] private TextMeshProUGUI treasureText;

    void Update()
    {
        treasureText.text = treasureCollected.ToString() + " / 4";
    }
}
