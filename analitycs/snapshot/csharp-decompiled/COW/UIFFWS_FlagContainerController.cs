using UnityEngine;

namespace COW;

public class UIFFWS_FlagContainerController : MonoBehaviour
{
	private const int TeamInfoOneSide = 6;

	public UIGrid FlagListLeft;

	public UIGrid FlagListRight;

	public GameObject FlagTeamItem;

	protected void Awake()
	{
	}

	protected void OnDestroy()
	{
	}
}
