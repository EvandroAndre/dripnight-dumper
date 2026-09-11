using GCommon;
using proto;

namespace COW;

internal class UIProfileWeaponNodePickItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private class UIProfileWeaponPowerTitleController
	{
		private UIProfileWeaponNodePickItemController m_PickItemController;

		private WeaponPowerTitleRecordInfo m_TitleInfo;

		private WeaponExpInfo m_ExpInfo;

		private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

		private UIModelWeaponPower m_ModelWeaponPower;

		private UIModelProfile m_ModelProfile;

		private UIModelWeaponProficiency m_ModelWeaponProficiency;

		private UILeaderBoardTitleIconController m_LeaderBoardTitleIconController;

		private bool m_HasWeaponPowerTitle;

		public UIProfileWeaponPowerTitleController(UIProfileWeaponNodePickItemController pickItemController)
		{
		}

		public void SetData(WeaponPowerTitleRecordInfo info)
		{
		}

		private void InitData()
		{
		}

		private void RefreshView()
		{
		}

		private void SetBG()
		{
		}

		private void SetLabel()
		{
		}

		private void SetIcon()
		{
		}

		private void SetUIActive()
		{
		}

		public void SetExpData(uint exp)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIModelRandomCollection modelRandomCollection;

		public UIProfileWeaponNodePickItemController _003C_003E4__this;

		internal bool _003CRefreshWeaponSkinView_003Eb__0(WeaponSkinBaseInfo info)
		{
			return false;
		}
	}

	private WeaponPowerTitleRecordInfo m_TitleInfo;

	private UIProfileWeaponPowerTitleController m_WeaponPowerTitleController;

	private UIProfileWeaponNodeController m_ProfileWeaponNodeController;

	private UIModelProfile m_ModelProfile;

	private UIModelWeaponProficiency m_ModelWeaponProficiency;

	private UIModelCollection m_ModelCollection;

	private UIModelInventory m_ModelInventory;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIProfileWeaponNodePickItemView m_View;

	private UIProfileWeaponNodeController ProfileWeaponNodeController => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshTitleView()
	{
	}

	private void RefreshWeaponSkinView()
	{
	}

	private void RefreshDetailDataView()
	{
	}

	private void OnButtonItemClick()
	{
	}

	private ELeaderBoardTitleRegionType SelectLowestRegionType()
	{
		return ELeaderBoardTitleRegionType.None;
	}

	private void OpenNextTargetPopupByLeaderboardID(ulong leaderboardID)
	{
	}

	private void OpenNextTargetPopupByNextSore(uint nextScore)
	{
	}

	private void EventEnableItemButton(bool enable)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
