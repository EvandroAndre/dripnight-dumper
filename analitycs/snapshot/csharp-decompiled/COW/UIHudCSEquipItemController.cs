using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudCSEquipItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public bool hasWeapon;

		internal bool _003CCheckRecommendNeedShow_003Eb__1(CSShopRecommendSetData x)
		{
			return false;
		}
	}

	protected UIHudInGameShopItemViewExt m_View;

	protected CSShopItemData m_Data;

	protected bool m_Selected;

	private bool m_IsCSAbilityPointChoosed;

	private uint m_CurSelectedCSAbilityPointLevel;

	private const uint SHOULDSHOW_BASE = 1u;

	private const uint SHOULDSHOW_CSABILITY_POINT = 2u;

	private BitArrayBoolean m_ShouldShow;

	private uint m_PurchaseCnt;

	private uint m_LimitCnt;

	protected uint m_Quality;

	private uint m_Price;

	private bool m_NeedRecommend;

	private List<CSShopRecommendSetData> m_RecommendDatas;

	private UIHudCSShopReplacerController m_ReplacerEffect;

	private GameObject[] m_LevelTips;

	private uint m_RecommendTutorialDelayCall;

	private float m_StartPressTime;

	private float m_LastClickTime;

	private GameObject[] m_BuffTips;

	private uint m_BuffId;

	private GameObject m_PressedBtn;

	private VisualInstanceHolder m_VfxSingleEffectHolder;

	private VisualInstanceHolder m_AdditionalUIHolder;

	private string m_TechPointIconDefault;

	private int m_TechPointIconHeightDefault;

	private Color m_TechPointIconColorDefault;

	private ResourceID m_PowerUpAbilityPointFXDefault;

	private ResourceID m_PowerUpShelterFXDefault;

	private uint m_FinishReinforceVFXDelayCall;

	private const string TOKENFORMAT = "{0}/{1}";

	private const string TOKENNOTENOUGHFORMAT = "[ED1C24]{0}[-][D1D1D1]/{1}[-]";

	private Color m_TokenEnoughLabelColor;

	private VisualInstanceHolder m_UIFXSurpriseItemPuschasedHolder;

	private bool m_ReinforceBtnRegisteredForBotAgent;

	private uint m_ShowNewbieCSShopPurchaseGuideDelaCallId;

	private bool m_ShowNewbieCSShopPurchaseGuide;

	private bool m_NewbieCSShopPurchaseGuide;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void RefreshBooyahBountyCoin(uint data0, uint data1)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	private void OnItemBtnClick()
	{
	}

	private void TryTriggerReinforceRecommendation()
	{
	}

	public UIButton GetTutorialBindingBtn()
	{
		return null;
	}

	public UIWidget GetTutorialBindingWidget()
	{
		return null;
	}

	private void RefreshGradeLevelTips(CSShopItemData data, bool battleLevelOpen, NKDHFJHPEFL battleLevelModule, ONFBHNEPBCM battleStyleModule)
	{
	}

	private void RefreshBattleLevelPurchaseLimitation(CSShopItemData data, NKDHFJHPEFL battleLevelModule)
	{
	}

	private void RefreshBattleStyleAbilityPurchaseLimitation(CSShopItemData data, ONFBHNEPBCM battleStyleModule)
	{
	}

	public void SetUIData(CSShopItemData data, uint quality = 0u, bool isPurchaseRefresh = false, bool forceInit = false)
	{
	}

	private void SetSkin(bool resetToDefault = false)
	{
	}

	private void RecordDefaultSkin()
	{
	}

	private static ResourceID GetVFXHelperDefaultResId(VFXCreateHelper vfxHelper)
	{
		return default(ResourceID);
	}

	private void UpdateActivityItemIconShowState()
	{
	}

	public void SetRecommend(bool flag, List<CSShopRecommendSetData> data)
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	private void RefreshPrice(object[] data)
	{
	}

	private void RefreshPoint(uint teamId)
	{
	}

	private void CheckItemsValid()
	{
	}

	private void CheckLimitation()
	{
	}

	private uint GetTeamLimitCount()
	{
		return 0u;
	}

	private uint GetLimitCount()
	{
		return 0u;
	}

	private void OnItemPurchased(object[] data)
	{
	}

	private bool CheckPriceValid()
	{
		return false;
	}

	private void CheckRecommendNeedShow()
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	private void SetSelected(bool v)
	{
	}

	private void ResetSelectedState()
	{
	}

	public void ResetForRecycle()
	{
	}

	private void RefreshHighlightCSAbilityPoint()
	{
	}

	private void OnCoinChanged(int data)
	{
	}

	private void OnShow(object[] data)
	{
	}

	private void RefreshLimitation(object[] data)
	{
	}

	private void OnFreeCardCountChanged(object[] data)
	{
	}

	public void ShowTutorial(TutorialEventEnum eTutorialEvent)
	{
	}

	private void OnODFactionChange(object[] data)
	{
	}

	private void OnItemAccountChanged(uint itemID)
	{
	}

	private void OnRefreshNewTag(uint itemID)
	{
	}

	private void OnBattleLevelModuleLevelChange(uint playerID)
	{
	}

	private void OnBattleStyleModuleLevelChange(uint playerID)
	{
	}

	public uint GetDataItemId()
	{
		return 0u;
	}

	public void SetBuffData(uint buffId)
	{
	}

	private void OnItemPress(GameObject go, bool pressed)
	{
	}

	private void OnItemClick(GameObject go)
	{
	}

	private void ShowDetail()
	{
	}

	private void HideDetail()
	{
	}

	public UIWidget GetItemWidget()
	{
		return null;
	}

	protected virtual bool OnCheckItemCanShow(CSShopItemData data)
	{
		return false;
	}

	protected virtual void OnAfterSetShopItemData(CSShopItemData data)
	{
	}

	public void ShowRefreshVFX()
	{
	}

	public void ReSyncSelectedInfo()
	{
	}

	private void OnEPChanged(GEvent data)
	{
	}

	private void OnFilterSingleEffectChanged(int filterID, int itemID)
	{
	}

	private void SetSingleEffect(bool showSingleEffect)
	{
	}

	private void OnSyncReinforceItems()
	{
	}

	private void OnReinforceItemChanged(uint itemId)
	{
	}

	private void OnReinforceTokenChanged(int newTokenCount, int oldTokenCount)
	{
	}

	private void ShowReinforceVFX()
	{
	}

	private void CancelReinforceVFXDelayCall()
	{
	}

	private void RefreshReinforcedBG()
	{
	}

	private void RefreshLoadoutReinforceBtn(bool isSelected)
	{
	}

	private void OnLoadoutReinforceBtnClick()
	{
	}

	public void SetCurSelectedCSAbilityPointLevel(uint level)
	{
	}

	private bool CalcShouldShowBase(CSShopItemData data, bool isPurchaseRefresh, bool battleLevelOpen, NKDHFJHPEFL battleLevelModule, ONFBHNEPBCM styleModule)
	{
		return false;
	}

	private bool IsCurrentlyProvidedByCSAbilityPoint()
	{
		return false;
	}

	private void RefreshShowOrHide()
	{
	}

	private void RefreshCSAbilityPointItemState()
	{
	}

	private void OnReplaceShopItem(uint itemId)
	{
	}

	private void OnPurchaseSuccess(object[] data)
	{
	}

	private void PlayEffectSurpriseItemPuschased()
	{
	}

	private void OnShowCSAgentRecommendGuide(uint itemID)
	{
	}

	public void RegisterReinforceBtnForBotAgent()
	{
	}

	public void UnRegisterReinforceBtnForBotAgent()
	{
	}

	public void TryShowNewbieCSShopPurchaseGuide()
	{
	}

	private void ClearShowNewbieCSShopPurchaseGuideDelaCallId()
	{
	}

	private void _003CCheckRecommendNeedShow_003Eb__59_0()
	{
	}

	private bool _003CRefreshLimitation_003Eb__67_0(LJCEMHFBNNN i)
	{
		return false;
	}

	private void _003CShowReinforceVFX_003Eb__93_0()
	{
	}

	private void _003CTryShowNewbieCSShopPurchaseGuide_003Eb__117_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
