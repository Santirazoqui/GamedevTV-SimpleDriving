using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] float scoreMultiplier = 10;
    private float score = 0;

    // Update is called once per frame
    void Update()
    {
        score += scoreMultiplier * Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
}
