using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballScoreTrigger : MonoBehaviour
{
	public ParticleSystem particleEffect;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Ball"))
		{
			if (particleEffect != null)
			{
				particleEffect.Play();
			}
			else
			{
				Debug.LogWarning("no effect");
			}
		}
	}
}
