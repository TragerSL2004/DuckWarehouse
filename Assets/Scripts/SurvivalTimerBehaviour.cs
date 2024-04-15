using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalTimerBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private TextMeshProUGUI _gameOverText;

    private float _timeSurvived = 0f;

    private string _store;

    private bool _gameOver = false;

    private void Start()
    {
        _store = _text.text;
    }
    private void Update()
    {
        if (_gameOver)
        {
            _text.text = "";
            _gameOverText.text = "Game Over, you survived for " + _timeSurvived + " seconds.";
        }

        _text.text = _store + _timeSurvived;
        _timeSurvived += Time.deltaTime;
    }

    public void SetGameOver()
    {
        _gameOver = true;
    }
}
