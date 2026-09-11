using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIAvatarProficiencyController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__18_0;

		internal void _003CInitCompnetList_003Eb__18_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public AvatarProficiencyRewardDesc item;

		public UIAvatarProficiencyController _003C_003E4__this;

		internal void _003CSetAwardList_003Eb__0()
		{
		}
	}

	private UIAvatarProficiencyView m_View;

	private uint m_AvatarId;

	private AvatarProfile m_Profile;

	private bool isClaiming;

	private readonly List<UIStandardItemMiniController> m_AwardCtrlList;

	private List<UILabel> m_LabelList;

	private List<Transform> m_Transforms;

	private List<UISprite> m_ReceivedSprites;

	private List<UISprite> m_AvailableSprites;

	private List<UISprite> m_InactivedSprites;

	private List<UISprite> m_ProgressBars;

	private List<GameObject> m_QuestionMark;

	private List<AvatarProficiencyRewardDesc> m_AvatarAwardList;

	private List<UIButton> m_QuestionMarkBtnList;

	private AvatarProficiencyInfo m_ProficiencyInfo;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitCompnetList()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitAwardList(int awardNum)
	{
	}

	private void SetAwardList()
	{
	}

	private void SetLabels()
	{
	}

	public void SetData(uint avatarId)
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
