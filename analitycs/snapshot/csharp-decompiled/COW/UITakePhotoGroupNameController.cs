using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupNameController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public UITakePhotoGroupNameController _003C_003E4__this;

		public List<ResourceID> res_list;

		internal void _003CRefreshDowloadCtrl_003Eb__0()
		{
		}
	}

	private bool m_IsSelect;

	private UITakePhotoGroupNameView m_View;

	private GroupPhotoAvatar m_Data;

	private GroupPhotoTemplateData m_TemplateData;

	private bool IsEmpty;

	private bool IsShowName;

	private uint m_PosId;

	private bool m_IsBR;

	private uint m_SeasonReplayTab;

	private UINewDownloadInfoController m_DownloadController;

	private UITakePhotoGroupBaseController m_GroupPhotoCtrl;

	public UISeasonReplaySocialSocialTagController m_SeasonReplaySocialSocialTagCtrl;

	private Color PointColor;

	private Color BtnIconSelectColor;

	private Color BtnIconUnSelectColor;

	private bool m_IsSelectEditBackground;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnExChangeBtn()
	{
	}

	private void OnPlusBtn()
	{
	}

	private void OnSwitchBtnClick()
	{
	}

	private void OnDeleteBtn()
	{
	}

	public void SetData(GroupPhotoAvatar groupPhotoAvatar, GroupPhotoTemplateData templateData, uint pos_id, bool isSeasonReplay, bool isBR, uint seasonReplayTab, bool noSetSeasonReplay = false)
	{
	}

	private void RefreshBtnBox(GroupPhotoTemplateData templateData, uint pos_id)
	{
	}

	private void SetSeasonReplayData(GroupPhotoAvatar groupPhotoAvatar, GroupPhotoTemplatePoseData templateData, bool isBR, uint seasonReplayTab, int poseCount)
	{
	}

	public void SaveSelectedFriendData(ulong accountId, List<SeasonReplayFriendData> dataList)
	{
	}

	public List<SeasonReplayFriendData> GetSelectedFriendData(ulong accountId)
	{
		return null;
	}

	public void BeforeSeasonReplayScreenShot()
	{
	}

	public void AfterSeasonReplayScreenShot()
	{
	}

	private void RefreshDowloadCtrl()
	{
	}

	public void HideName(bool show)
	{
	}

	public void AfterShare()
	{
	}

	public void BeforeShare()
	{
	}

	public void RefreshSelect(bool isSelected)
	{
	}

	private void RefreshBtnBg()
	{
	}

	public void RefreshBtnTable(bool isSelectEditBackground)
	{
	}

	private void _003CSetData_003Eb__22_0()
	{
	}

	private void _003CSetData_003Eb__22_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
