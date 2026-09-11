using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudEnemyReviveHintItemController : UIBaseController
{
	private UIHudEnemyReviveHintItemView m_View;

	public Transform CachedTransform;

	private Color m_BaseColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(float angle, float distanceRatio)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
