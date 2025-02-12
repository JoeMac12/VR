using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketballScoreTrigger : MonoBehaviour
{
	public TextMeshProUGUI scoreText;
	private int score = 0;

	private void Start()
	{
		UpdateScoreText();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Ball"))
		{
			score++;
			UpdateScoreText();
		}
	}

	private void UpdateScoreText()
	{
		if (scoreText != null)
		{
			scoreText.text = "Score: " + score;
		}
	}
}
