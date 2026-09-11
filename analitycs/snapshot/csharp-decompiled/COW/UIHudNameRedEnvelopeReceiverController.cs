using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudNameRedEnvelopeReceiverController : UIHudNameBaseController
{
	private UIHudNameRedEnvelopeReceiverView m_View;

	private Player m_Receiver;

	private uint m_DelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnEventClose()
	{
	}

	public void BindPlayer(Player player, ulong ownerID, string ownerName, bool isLucky, uint itemID)
	{
	}

	private void RemoveSelf()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}
}
