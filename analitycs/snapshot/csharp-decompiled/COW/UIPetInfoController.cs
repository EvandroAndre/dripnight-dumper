using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIPetInfoController : UIPreviewNavigationController, IEasyList, IUIModelDataChangeObserver
{
	private enum SortOrder
	{
		PetId,
		OrderSource,
		NotOwned,
		Owned,
		Star,
		NewObtain,
		Equip
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__57_0;

		internal void _003CBuyPet_003Eb__57_0(string st)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass127_0
	{
		public string targetString;

		internal void _003CTryShowActiveSkillGuide_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public object[] param;

		internal bool _003CGotoPet_003Eb__0(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public object[] param;

		internal bool _003CRefreshPetInfoPanel_003Eb__0(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public PetActionData data;

		internal bool _003CShowActionList_003Eb__0(PetActionInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public PetSkinData data;

		internal bool _003CShowSkinList_003Eb__0(PetSkinInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_1
	{
		public proto.PetInfo info;

		internal bool _003CShowSkinList_003Eb__1(PetSkinData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_2
	{
		public PetData data;

		internal bool _003CShowSkinList_003Eb__2(PetSkinData temp)
		{
			return false;
		}
	}

	private sealed class _003CDisableBehaviourGuideCoroutine_003Ed__130 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPetInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDisableBehaviourGuideCoroutine_003Ed__130(int _003C_003E1__state)
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

	private sealed class _003CProgressBarAnimation_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPetInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CProgressBarAnimation_003Ed__73(int _003C_003E1__state)
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

	private UIPetView m_View;

	private const string PET_RENAME_TAG = "PET_ITEM_NEW_TAG";

	private const string PET_ACTIVE_SKILL_GUIDE = "PET_ACTIVE_SKILL_GUIDE_{0}_{1}";

	private const string PET_SELECT_SKILL_TAG = "PET_SKILL_SELECT_TAG";

	private const string PET_FOOD_SUFFICIENT = "[FFB300FF]{0}[-]/{1}";

	private const string PET_FOOD_INSUFFICIENT = "[EF3030FF]{0}[-]/{1}";

	private const string PET_CARRY_GUIDE = "PET_CARRY_GUIDE";

	private const string PET_LEVELUP_GUIDE = "PET_LEVELUP_GUIDE";

	private const string PET_DISABLE_BEHAVIOUR_GUIDE = "PET_DISABLE_BEHAVIOUR_GUIDE";

	private const string m_IngameAutoHidePetToggleLogLabel = "IngameAutoHidePetToggle";

	private uint current_show_pet_id;

	private uint current_show_skin_id;

	private UIModelPet m_PetModel;

	private UIModelEvoPass m_ModelEvoPass;

	private UIPetAvatar pet_avatar;

	private Item current_use_food;

	private int anim_start_level;

	private int anim_start_exp;

	private float anim_current_exp;

	private int anim_end_exp;

	private int anim_current_level;

	private bool anim_start_flag;

	private float anim_speed;

	private UIShowType Show_grid_flag;

	private uint max_feed_count;

	private uint next_level_feed_count;

	private UIPetNormalGridController m_normalGridController;

	private UIPetSkillGridController m_skillGridController;

	private UICommonGuideController m_PetLevelUpGuide;

	private UICommonGuideController m_PetCarryGuide;

	private UICommonGuideController m_PetDisableGuide;

	private bool m_BuyPetFootWaitStoreRes;

	private bool m_BuyPetWaitStoreRes;

	private int m_GuideStep;

	private UIModelLoadout m_ModelLoadout;

	private uint PassInPetId;

	private Coroutine m_ProgressBarCoroutine;

	private UIUtils.ScreenshotType m_CurrentScreenshotType;

	private float m_TimePhase;

	private uint m_DelayCallID;

	private bool m_ForbidEsc;

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnActionBtnClick()
	{
	}

	private void OnSkinBtnClick()
	{
	}

	private void OnSkillBtnClick()
	{
	}

	private void SetTitleBtnState(UIShowType type)
	{
	}

	private void PlayAnimation(object[] param)
	{
	}

	private void ChangeSkin(object[] param)
	{
	}

	private void ChangeSelectSkill(object[] param)
	{
	}

	private void RefreshInfoContainer(CSSharedItemData inventoryItem)
	{
	}

	private void SetPetNameInfoBg(uint rare)
	{
	}

	private Color GetPetNameInfoBgColor(uint rare)
	{
		return default(Color);
	}

	private void RefreshPriviewUIShow(int index)
	{
	}

	protected void HighLightItem(int itemIndex, UIEasyList grid, bool needClick = false, bool showTips = false)
	{
	}

	private void UpdatePetPanelContainer()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void RefreshPetList()
	{
	}

	private void OnBuyPetClick()
	{
	}

	private void BuyPet()
	{
	}

	public void CheckNewTag(object[] param)
	{
	}

	private void ResetItemInfoShow()
	{
	}

	private void GotoPet(object[] param)
	{
	}

	private void RefreshDownLoadState(object[] param)
	{
	}

	private void SetSelectBtnShow(object[] param)
	{
	}

	private void RecoverLevelUpBtnState(object[] param)
	{
	}

	private void RefreshPetInfoPanel(object[] param)
	{
	}

	private void ShowGridInfoList(PetConfigInfo config, bool selectByInfoIfNeed = true)
	{
	}

	private void RefreshPetExpLabel(PetLevelUpNtf data)
	{
	}

	private void RefreshMyPetInfoComponent(bool showFlag)
	{
	}

	private void RefreshMyPetFoodComponent()
	{
	}

	private void UpdateProgressBar(int exp_own, int exp_lvUp)
	{
	}

	private void TryStopProgressBarCoroutine()
	{
	}

	private void UpdateProgressBarAnim(int exp_old, int exp_own, int start_lv, int end_lv)
	{
	}

	private void StopProgressBarAnim()
	{
	}

	private IEnumerator ProgressBarAnimation()
	{
		return null;
	}

	private void CheckMaxLevel(int newLevel)
	{
	}

	private void UpdateSelectBtn()
	{
	}

	private void ShowActionList(List<PetActionData> dataList, bool selectByInfoIfNeed)
	{
	}

	private void ShowSkinList(List<PetSkinData> dataList, bool selectByInfoIfNeed)
	{
	}

	private void ShowCurrentSkillInfo(proto.PetInfo pet_info)
	{
	}

	private void ShowSkillList()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnShow()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void StopBGM(object[] data)
	{
	}

	private uint GetEquipPetSkillID()
	{
		return 0u;
	}

	private void OnCarryExpirePetClick()
	{
	}

	private void OnRestExpirePetClick()
	{
	}

	private void OnEvoPassGotoBtnClick()
	{
	}

	private void OnEvoPassTipClick()
	{
	}

	private void OnCarryStateClick()
	{
	}

	private void OnRenameClick()
	{
	}

	private void OnFeedPetLevelUpClick()
	{
	}

	private void SetFeedButtonClickState(bool state)
	{
	}

	private void OnBuyPetFoodClick()
	{
	}

	private void BuyPetFoot()
	{
	}

	private void RefreshIngameAutoHidePetToggleStatus()
	{
	}

	private void OnIngameAutoHidePetToggleClick()
	{
	}

	private uint CalPetLevelUpFeedCount()
	{
		return 0u;
	}

	private bool IsPetMaxLevel()
	{
		return false;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnShowPetClick()
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	private void OnLoveNodeClick()
	{
	}

	private void RefreshLoveNode()
	{
	}

	private void OnLoveNodeChanged(uint petid)
	{
	}

	private uint GetSortScore(proto.PetInfo target, proto.PetInfo temp)
	{
		return 0u;
	}

	private int SortPetInfoList(proto.PetInfo a, proto.PetInfo b)
	{
		return 0;
	}

	private void RefreshExpireTime()
	{
	}

	private void RefreshEvopassTip()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private bool IsPetEquipGuideNeeded()
	{
		return false;
	}

	private void UpdatePetLoadoutGuideToNextStep(EGuidePetAndLoadout step)
	{
	}

	private void ShowPetEquipGuide(proto.PetInfo info)
	{
	}

	private void TryShowActiveSkillGuide()
	{
	}

	private bool IsNeededActiveSkillGuide()
	{
		return false;
	}

	private void TryShowDisableBehaviourGuide()
	{
	}

	private IEnumerator DisableBehaviourGuideCoroutine()
	{
		return null;
	}

	private bool _003COnDataChanged_003Eb__38_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnActionBtnClick_003Eb__41_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnSkinBtnClick_003Eb__42_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnSkillBtnClick_003Eb__43_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003CUpdatePetPanelContainer_003Eb__53_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003CRefreshPetList_003Eb__55_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnCarryExpirePetClick_003Eb__88_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnRestExpirePetClick_003Eb__89_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnCarryStateClick_003Eb__92_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnFeedPetLevelUpClick_003Eb__94_0(proto.PetInfo temp)
	{
		return false;
	}

	private bool _003COnLoveNodeClick_003Eb__114_0(proto.PetInfo item)
	{
		return false;
	}

	private bool _003CRefreshLoveNode_003Eb__115_0(proto.PetInfo item)
	{
		return false;
	}

	private void _003COnLoveNodeChanged_003Eb__116_0()
	{
	}

	private bool _003CRefreshExpireTime_003Eb__120_0(proto.PetInfo x)
	{
		return false;
	}

	private void _003CShowPetEquipGuide_003Eb__126_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
