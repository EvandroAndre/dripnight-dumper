using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEnemyHypeLevelController : UIHudNameBaseController
{
	private UIHudEnemyHypeLevelView m_View;

	private BHGGAEEHJCO m_TargetPlayerID;

	private uint m_DelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID, int hypeLevel)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override Vector3 ExtraScreenGap()
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public Vector3 _003C_003EiFixBaseProxy_ExtraScreenGap()
	{
		return default(Vector3);
	}
}
