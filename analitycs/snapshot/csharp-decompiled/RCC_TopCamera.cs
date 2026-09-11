using UnityEngine;

public class RCC_TopCamera : MonoBehaviour
{
	public Transform playerCar;

	private Rigidbody playerRigid;

	private Camera cam;

	public GameObject pivot;

	public float distance;

	private float distanceOffset;

	public float maximumDistanceOffset;

	private float targetFieldOfView;

	public float minimumOrtSize;

	public float maximumOrtSize;

	private Vector3 targetPosition;

	private Vector3 pastFollowerPosition;

	private Vector3 pastTargetPosition;

	private float speed;

	public Transform _playerCar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void GetPlayerCar()
	{
	}

	public void SetPlayerCar(GameObject player)
	{
	}

	private void Update()
	{
	}

	private Vector3 SmoothApproach(Vector3 pastPosition, Vector3 pastTargetPosition, Vector3 targetPosition, float delta)
	{
		return default(Vector3);
	}
}
