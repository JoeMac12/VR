using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Shoots balls... thats it

public class BaseballShooter : MonoBehaviour
{
	public GameObject baseballPrefab;
	public float ballLifetime = 15f;
	public float shootForce = 500f;

	public AudioClip shootSound;
	public AudioSource audioSource;

	private void Start()
	{
		if (audioSource == null)
		{
			audioSource = GetComponent<AudioSource>();
		}
	}

	public void ShootBall()
	{
		if (shootSound != null)
		{
			if (audioSource != null)
			{
				audioSource.PlayOneShot(shootSound);
			}
			else
			{
				AudioSource.PlayClipAtPoint(shootSound, transform.position);
			}
		}

		GameObject baseball = Instantiate(baseballPrefab, transform.position, transform.rotation);

		Rigidbody rb = baseball.GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.AddForce(transform.forward * shootForce);
		}

		Destroy(baseball, ballLifetime);
	}
}
