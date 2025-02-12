using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Shoots balls... thats it

public class BaseballShooter : MonoBehaviour
{
	public GameObject baseballPrefab;
	public float shootTime = 5f;
	public float ballLifetime = 15f;
	public float shootForce = 500f;

	private void Start()
	{
		StartCoroutine(Shoot());
	}

	private IEnumerator Shoot()
	{
		while (true)
		{
			ShootBall();
			yield return new WaitForSeconds(shootTime);
		}
	}

	private void ShootBall()
	{
		GameObject baseball = Instantiate(baseballPrefab, transform.position, transform.rotation);

		Rigidbody rb = baseball.GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.AddForce(transform.forward * shootForce);
		}

		Destroy(baseball, ballLifetime);
	}
}
