using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudEscortVehicleProgressController : UIBaseController
{
	private class MileStoneInfo
	{
		public UISprite ProgressBar;

		public UISprite FlagIcon;

		public MileStoneInfo(UISprite progressBar, UISprite flag)
		{
		}
	}

	private UIHudEscortVehicleProgressView m_View;

	private BPKGNCEDKAL mGame;

	private MileStoneInfo[] m_MileStoneInfos;

	private const int TOTAL_MILESTONE_COUNT = 4;

	private const float TOTAL_PROGRESS_BAR_LENGHTH = 331.75f;

	private Color FLAG_FINISH_COLOR;

	private Color FLAG_UNFINISH_COLOR;

	private uint m_DelayCallID;

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

	private void OnCurrentMileStoneChanged(object[] data)
	{
	}

	private void UpdateMileStoneUI()
	{
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnVehiclePositionChanged(object[] data)
	{
	}

	private void OnEffectiveAttackerChanged(object[] data)
	{
	}

	private void RefreshEffectiveAttacker()
	{
	}

	private void OnEffectiveDefenderChanged(object[] data)
	{
	}

	private void RefreshEffectiveDefender()
	{
	}

	private void OnEquipmentConfirmed(object[] data)
	{
	}

	protected void WaitAndHide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
