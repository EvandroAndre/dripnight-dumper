using System;
using GCommon;

namespace COW;

internal class UIHudMatchResultWorkShopPanelController : UIBaseController, IUIModelDataChangeObserver
{
	private enum EClickedBtn
	{
		EDetail,
		EComment
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIHudMatchResultWorkShopPanelController _003C_003E4__this;

		public UIPopupMessageBoxController quitDialog;

		internal void _003COnGoToBtnClick_003Eb__0()
		{
		}

		internal void _003COnGoToBtnClick_003Eb__1()
		{
		}
	}

	private UIHudMatchResultWorkShopPanelView m_View;

	private UIModelMatch m_ModelMatch;

	private UIModelSceneEdit m_ModelSceneEdit;

	private Action<bool> m_ReqCallback;

	private bool m_CanBeSubscribed;

	private SceneEditSlotInfo m_SlotInfo;

	private EClickedBtn m_ClickedBtn;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RegistReqCallback(Action<bool> action)
	{
	}

	private void RefreshSubState()
	{
	}

	public void ShowInfo(bool show)
	{
	}

	private void OnWLikeBtnClick()
	{
	}

	private void OnWDisLikeBtnClick()
	{
	}

	private void OnWSubBtnClick()
	{
	}

	private void ShowConfirmWindow()
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnMapDetailButtonClick()
	{
	}

	public void OnCommentBtnClick()
	{
	}

	public void OnGoToBtnClick()
	{
	}

	private void HandleLeaveNtf(object[] param)
	{
	}

	private void OnSecondConfirmBtnClick()
	{
	}

	private void OnReturn()
	{
	}

	public void ShowCommentInfo()
	{
	}

	public void ShowDetailInfo()
	{
	}

	private void _003COnWSubBtnClick_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
