using UnityEngine;

namespace COW;

public class GiveMeFiveAnimController : MonoBehaviour
{
	public const string AnimFailName = "Failure";

	public static readonly int AnimFailHash;

	public const string AnimTeammateFailName = "Failure_teammate";

	public static readonly int AnimTeammateFailHash;

	public const string AnimFlightName = "flight";

	public static readonly int AnimFlightHash;

	public const string AnimFlightEndName = "flight_01";

	public static readonly int AnimFlightEndHash;

	public Animator animator;

	public void PlayFailAnim()
	{
	}

	public void PlayTeammateFailAnim()
	{
	}

	public void PlayFlightAnim()
	{
	}

	public void PlayFlightEndAnim()
	{
	}

	public float GetFailAnimLength()
	{
		return 0f;
	}

	public float GetTeammateFailAnimLength()
	{
		return 0f;
	}

	public float GetFlightEndAnimLength()
	{
		return 0f;
	}

	private float GetAnimLength(int animHash)
	{
		return 0f;
	}
}
