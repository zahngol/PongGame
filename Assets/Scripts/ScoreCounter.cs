using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    public void IncreaseScore()
    {
        score++;
        textMeshPro.text = score.ToString();
    }
}
