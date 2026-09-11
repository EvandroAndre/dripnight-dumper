using System.Collections.Generic;
using GCommon;

namespace COW;

public class UICSPeakTournamentTaskRewardController : UIBaseController, IUIModelDataChangeObserver
{
	private UICSPeakTournamentTaskRewardView m_View;

	private List<UICSPeakTournamentTaskRewardItemController> m_RewardItemControllers;

	private UICSPeakTournamentTaskRewardItemController m_LastRewardItemCtrl;

	private UIModelCollection m_ModelCollection;

	private UIModelInventory m_ModelInventory;

	private UIModelPrime m_ModelPrime;

	private uint m_CurrentShowAwardID;

	private bool m_AvatarFrameSelectWndOpen;

	private UICSRankStarIconController m_CSRankStarIconCtrl;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

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

	protected override void OnUIOpenAsChild()
	{
	}

	private void RefreshUIData()
	{
	}

	private void OnGotoRankSystemBtnClick()
	{
	}

	private void OnDisplayBtnClick()
	{
	}

	private void OnGoMatchBtnClick()
	{
	}

	public void SetRewardUIData(bool defaultSelect = false)
	{
	}

	private void OnAvatarFrameSelectWndClose()
	{
	}

	private void RefreshAvatarFrameDisplayBtn()
	{
	}

	private void InitBottomGoMatchBtn()
	{
	}

	private void ResetWinPassSelectedState(object[] data)
	{
	}

	public void ShowPrevSelectedItemPreview()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CInitBottomGoMatchBtn_003Eb__21_2()
	{
	}

	private void _003CInitBottomGoMatchBtn_003Eb__21_3()
	{
	}

	private void _003CInitBottomGoMatchBtn_003Eb__21_0()
	{
	}

	private void _003CInitBottomGoMatchBtn_003Eb__21_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
