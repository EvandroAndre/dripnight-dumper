using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudBombHintController : UIBaseController, IUIModelDataChangeObserver
{
	private UIModelMatch m_MatchModel;

	private UIHudBombHintView m_View;

	public Color iconTintWhiteColor;

	public Color iconTintYellowColor;

	private uint m_DelayCall;

	private IIBMILKCJMH m_BombGame;

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

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void UpdateHintInfo(BombModeNotification notification, bool needAutoHide = true)
	{
	}

	private void On3PPreparation(object[] data)
	{
	}

	private void _003CUpdateHintInfo_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
