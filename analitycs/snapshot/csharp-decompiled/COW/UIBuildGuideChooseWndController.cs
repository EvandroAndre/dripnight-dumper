using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBuildGuideChooseWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private bool m_IsNewbie;

	private UIBuildGuideChooseWndView m_View;

	private UIModelLoadout m_ModelLoadout;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelMatch m_ModelMatch;

	private Action m_OnCloseAction;

	private List<Transform> m_NewbieSkillPos;

	private List<Transform> m_VeteranSkillPos;

	private List<UIBuildGuideChooseWndItemController> m_Items;

	private List<uint> m_NewbieSkills;

	private NewbiePresetDesc m_NewbiePresetData;

	private List<NewbiePresetDesc> m_VeteranPresetData;

	public int SelectedIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetCloseAction(Action closeAction)
	{
	}

	public void SetRole(bool isNewBie)
	{
	}

	private void InitItem()
	{
	}

	private void OnClickConfirmBtn()
	{
	}

	private bool GetHaveOwnAvatar(uint avatarId)
	{
		return false;
	}

	private void EnableNewbiewBtn()
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

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
