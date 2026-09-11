using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UINavigationTopbarController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UINavigationTopbarViewData viewData;

		public UINavigationTopbarController _003C_003E4__this;

		internal void _003CSetViewData_003Eb__0()
		{
		}

		internal void _003CSetViewData_003Eb__1(ResourceID gotoSpriteID, ResourceID gotoTagID, string label)
		{
		}

		internal UITopButtonGotoTokenController _003CSetViewData_003Eb__2(int index)
		{
			return null;
		}

		internal void _003CSetViewData_003Eb__3(UINavigationTopbarViewData.GotoTokenDetailData detailData)
		{
		}

		internal void _003CSetViewData_003Eb__4(string pageIcon, string pageLocKey, Action onTopBarEntryClick)
		{
		}

		internal void _003CSetViewData_003Eb__5(bool reposition)
		{
		}

		internal UIWidget _003CSetViewData_003Eb__6()
		{
			return null;
		}

		internal UIWidget _003CSetViewData_003Eb__7()
		{
			return null;
		}

		internal UIButton _003CSetViewData_003Eb__8()
		{
			return null;
		}

		internal void _003CSetViewData_003Eb__9(int index, bool state, bool reposition)
		{
		}

		internal void _003CSetViewData_003Eb__10(int index, ResourceID id, int num, bool timeLimit, uint itemID)
		{
		}

		internal void _003CSetViewData_003Eb__11(uint chestID)
		{
		}

		internal void _003CSetViewData_003Eb__12(uint chestID)
		{
		}

		internal UIBaseController _003CSetViewData_003Eb__13(Type uiType)
		{
			return null;
		}

		internal void _003CSetViewData_003Eb__14(bool IsShow)
		{
		}
	}

	private UINavigationTopbarView m_View;

	protected UILobbyProfileController m_Profile;

	private UILobbyV2CoinsController m_V2Coins;

	protected UITopButtonGroupController m_TopBtns;

	private UILobbyChatController m_ChatBtn;

	private UILobbyOptionalDownloaderController m_OptionalDownload;

	private UIClanTopLeftProfileController m_ClanCtrl;

	private UILobbyV2LobbySwitchBtnController m_LobbySwitchBtn;

	private UINavigationTopbarViewData m_ViewData;

	public UIWidget TopBarHelpBtnWidget => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShowTakePhoto(object[] objects)
	{
	}

	private void OnCloseTakePhoto(object[] objects)
	{
	}

	public void SetTakePhotoEndPos()
	{
	}

	public void SetTakePhotoStartPos()
	{
	}

	private void OpenTopButtonGotoTokenWithDetailData(UINavigationTopbarViewData.GotoTokenDetailData detailData)
	{
	}

	private void AppendAndOpenGotoTokenDetailData(UINavigationTopbarViewData viewData, UINavigationTopbarViewData.GotoTokenDetailData detailData)
	{
	}

	public void SetViewData(UINavigationTopbarViewData viewData)
	{
	}

	public void RefreshTopBtnOwnerInfo()
	{
	}

	private void UpdateUIActiveState()
	{
	}

	private void UpdateProfileState(ulong account)
	{
	}

	private void UpdateClanState(bool show)
	{
	}

	private void OnViewDataPropertyChanged(UINavigationTopbarViewData.PropertyChangeName propertyName)
	{
	}

	private void SetControllActive(UIBaseController controller, bool active)
	{
	}

	public Transform GetTopRightTransform()
	{
		return null;
	}

	public void SetLobbySwitchBtnVisiable(uint flag, bool v)
	{
	}

	private void InitCtrl()
	{
	}

	private void _003CInitCtrl_003Eb__28_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
