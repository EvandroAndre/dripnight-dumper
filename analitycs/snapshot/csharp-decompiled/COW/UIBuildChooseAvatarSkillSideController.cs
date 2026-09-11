using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBuildChooseAvatarSkillSideController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum SkillTemplateType
	{
		SkillItem,
		SplitLine,
		RecSplitLine,
		ActiveEquipped
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIModelAvatarProfile model;

		internal bool _003CAppendNotOwnSkills_003Eb__0(AvatarProfile a)
		{
			return false;
		}
	}

	private sealed class _003CAutoScrollCo_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBuildChooseAvatarSkillSideController _003C_003E4__this;

		public int value;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoScrollCo_003Ed__68(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDisableDragUntilAnimationComplete_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBuildChooseAvatarSkillSideController _003C_003E4__this;

		private UIScrollView _003CscrollView_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDisableDragUntilAnimationComplete_003Ed__56(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private int m_SlotIndex;

	private bool m_ChooseSkillMenuCreated;

	private bool m_IsFirstTimeOpen;

	private uint m_CurrentTag;

	private int m_LastClickIndex;

	private bool m_IsShowActiveList;

	private bool m_IsSearching;

	private string m_SearchContent;

	private uint m_NewSkillGuideAvatarID;

	private UIAvatarNewCharacterGuideController m_NewCharacterGuideCtrl;

	private UIBuildChooseAvatarSkillSideView m_View;

	private UIAvatarSkillSlotController m_Slotctrl;

	private UIAvatarSkillSlotController m_PassiveEquipActiveSkillCtrl;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelLoadout m_ModelLoadout;

	private UIModelMall m_ModelMall;

	private List<SkillInfo> m_SkillList;

	private UITipsNormalController m_PassiveRedTipsCtrl;

	private UITipsNormalController m_ActiveRedTipsCtrl;

	private bool m_IsActiveRedTipsShowing;

	private bool m_IsPassiveRedTipsShowing;

	private Coroutine m_AutoScrollCo;

	private const float DragScrollDelta = 20f;

	private uint m_DelayShowGuideId;

	private float m_DelayShowGuideTime;

	private bool m_ShowGuideV2;

	private bool m_ForbidEsc;

	private bool m_HasNewSkillGuide;

	public bool ForbidEsc
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void Awake()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void BuildCloseSide()
	{
	}

	private void OnActiveMenuSelected()
	{
	}

	private void OnPassiveMenuSelected()
	{
	}

	private void InitView()
	{
	}

	private void GetSkillList(bool isActiveSkill)
	{
	}

	private void RefreshListDataNotScroll()
	{
	}

	private void AppendAvailableSkills(bool isActiveSkill)
	{
	}

	private void AppendNotOwnSkills(bool isActiveSkill)
	{
	}

	private void AppendCloseFriendSkills(bool isActiveSkill)
	{
	}

	private void FillSkillEquipInfo()
	{
	}

	private bool IsEquippedSkill(uint skillId, bool isShared)
	{
		return false;
	}

	private bool IsSelectedSkill(SkillInfo skillInfo, uint skillId, bool isShared)
	{
		return false;
	}

	private void CancelDelayCall()
	{
	}

	private void InitPassiveSkillTemplate()
	{
	}

	public void ForceEnableSpring()
	{
	}

	private void InitActiveSkillTemplate()
	{
	}

	private void RefreshEquippedActiveSkill()
	{
	}

	private void GetSelectedSkillInfo(out uint selectedSkillId, out bool isShared)
	{
		selectedSkillId = default(uint);
		isShared = default(bool);
	}

	private uint GetSelectedSkillId()
	{
		return 0u;
	}

	private bool SelectedIsActiveSkill()
	{
		return false;
	}

	private void RefreshMenuToggle(bool selectActiveMenu)
	{
	}

	public void Refresh()
	{
	}

	private void PassiveListRefresh(List<SkillInfo> skilInfos)
	{
	}

	private void ActiveListRefresh(List<SkillInfo> skillInfos, bool hasEquippedActiveSkill = false)
	{
	}

	private int GetSkillColor(char color)
	{
		return 0;
	}

	private int SkillCompare(SkillInfo a, SkillInfo b)
	{
		return 0;
	}

	private void CreateLeaderBoardMenu()
	{
	}

	private IEnumerator DisableDragUntilAnimationComplete()
	{
		return null;
	}

	private int GetInOtherSlotActiveSkillSlotIndex()
	{
		return 0;
	}

	private void OnTypeSelected(uint popMenuType)
	{
	}

	private void OnEquippedActiveSkillBtnClick()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnInputChanged()
	{
	}

	private void OnClearBtnClick()
	{
	}

	private void OnSearchQuitBtnClick()
	{
	}

	private void OnSearchEntrenceBtnClick()
	{
	}

	private void OnPresetAgentPinStateChanged(object[] data)
	{
	}

	private IEnumerator AutoScrollCo(int value)
	{
		return null;
	}

	public void SetData(int slotindex)
	{
	}

	public void SetSlot(int slotindex)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void ScrollToItem(bool isActiveSkill)
	{
	}

	public void SetClickIndex(int index)
	{
	}

	private void InitGuide()
	{
	}

	private void StartNewSkillGuideV2()
	{
	}

	private void DelayShowGuideV2()
	{
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void CancelGuide()
	{
	}

	private void RefreshNewCharacterGuide()
	{
	}

	private void RefreshNewCharacterTips()
	{
	}

	private void onUpdateNewCharacterGuide()
	{
	}

	private bool CheckIsSkillShowing(uint avatarID)
	{
		return false;
	}

	private int GetSkillItemIndexInTable(uint avatarID)
	{
		return 0;
	}

	public void ScrollToIndexBySkillAvatarID(uint avatarID)
	{
	}

	private void Update()
	{
	}

	private void _003COnUIInit_003Eb__22_0()
	{
	}

	private void _003COnUIInit_003Eb__22_1()
	{
	}

	private void _003COnUIInit_003Eb__22_2()
	{
	}

	private void _003COnUIInit_003Eb__22_3()
	{
	}

	private void _003COnUIInit_003Eb__22_4()
	{
	}

	private UITable2.IUITable2Item _003CInitPassiveSkillTemplate_003Eb__42_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitPassiveSkillTemplate_003Eb__42_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitPassiveSkillTemplate_003Eb__42_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitActiveSkillTemplate_003Eb__44_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitActiveSkillTemplate_003Eb__44_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitActiveSkillTemplate_003Eb__44_2()
	{
		return null;
	}

	private void _003CDelayShowGuideV2_003Eb__82_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
