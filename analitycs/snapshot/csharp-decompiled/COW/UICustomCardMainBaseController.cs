using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UICustomCardMainBaseController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	protected GameObject m_DrawRootGo;

	protected UIButton m_DrawOneBtn;

	protected UINetworkTexture m_DrawOneBtnTexture;

	protected UILabel m_DrawOneBtnLabel;

	protected GameObject m_DrawFreeRedGo;

	protected GameObject tokenDrawOneRootGo;

	protected UISprite m_tokenDrawOneSprite;

	protected UILabel m_tokenDrawOneConsumeLabel;

	protected UIButton m_DrawFiveBtn;

	protected UINetworkTexture m_DrawFiveBtnTexture;

	protected UILabel m_DrawFiveBtnLabel;

	protected GameObject tokenDrawFiveRootGo;

	protected UISprite m_tokenDrawFiveSprite;

	protected UILabel m_tokenDrawFiveConsumeLabel;

	protected UINetworkTexture m_FloorRewardSmallBoxTexture;

	protected UIButton m_FloorRewardSmallBoxBtn;

	protected GameObject m_FloorRewardSmallGo;

	protected UINetworkTexture m_FloorRewardBoxTexture;

	protected Transform m_FloorRewardBoxEffectParent;

	protected UIButton m_FloorRewardBoxBtn;

	protected UINetworkTexture m_JackpotBtnTexture;

	protected UILabel m_JackpotBtnLabel;

	protected UIButton m_JackpotBtn;

	protected Animation m_Anim;

	protected List<UIBigEvent_CustomCard_MainCardInfoController> cards;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private ResourceID m_BoxEffectVFXResID;

	private GameObject m_BoxEffectVFXGO;

	private ResourceID m_SmallBoxEffectVFXResID;

	private GameObject m_SmallBoxEffectVFXGO;

	private ResourceID m_StageEffectVFXResID;

	private GameObject m_StageEffectVFXGO;

	private ResourceID m_AppearEffectVFXResID;

	private GameObject m_AppearEffectVFXGO;

	private ResourceID m_CombineEffectVFXResID;

	private GameObject m_CombineEffectVFXGO;

	private ResourceID m_DrawOneBtnEffectVFXResID;

	private GameObject m_DrawOneBtnEffectVFXGO;

	private ResourceID m_DrawFiveBtnEffectVFXResID;

	private GameObject m_DrawFiveBtnEffectVFXGO;

	private ResourceID m_FloorFlyEffectVFXResID;

	private GameObject m_FloorFlyEffectVFXGO;

	private uint m_CurrentFloorPrompt;

	private bool isOpenning;

	private uint m_AnimDelayKey;

	private float m_temp_length;

	private bool isLoopFloorReward;

	private const string CARD_COMBINE_ANIM = "UIFX_Ui_CustomCard_MainCard_Combine";

	private const string CARD_STAND_ANIM = "UIFX_Ui_CustomCard_MainCard_Stand";

	private const string SMALL_BOX_STAND_ANIM = "UIFX_Ui_CustomCard_holographic_Appear_Stand";

	private const string SMALL_BOX_DISAPPEAR_ANIM = "UIFX_Ui_CustomCard_holographic_Appear_death";

	private const string FLOOR_FLY_STAND_ANIM = "UIFX_CustomCard_TrailEffect01";

	private const string FLOOR_FLY_BOMB_ANIM = "UIFX_CustomCard_TrailEffect02";

	private const string CARDMAIN_IN_ANIM_END_EVT = "CustomCard_In_End";

	private const string BOX_APPEAR_ANIM_START_EVT = "CustomCard_Appear_Start";

	private const string BOX_APPEAR_ANIM_END_EVT = "CustomCard_Appear_End";

	private const string CARD_COMBINE_ANIM_END_EVT = "CustomCard_Box_Receive_End";

	protected const float CARD_ANIM_INTERVAL = 0f;

	protected const float FLOOR_FLY_EFFECT_DURATION = 0.5f;

	protected const float FLOOR_FLY_EFFECT_BOMB_DURATION = 1f;

	private int mCardCombimeAnimStage;

	private AutoOpenIntegrationData m_CacheFloorRewardData;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	protected virtual string BoxAppearAnim => null;

	protected virtual string BoxShakeAnim => null;

	protected virtual string CardCombineAnim => null;

	protected virtual string CardMainStandAnim => null;

	protected virtual string CardMainInAnim => null;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public bool GetFreeDrawGuide(out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	public abstract void CreateCard();

	public float GetAppearDelay(int index, int length, float interval)
	{
		return 0f;
	}

	protected void PlayCardAnim(string strAnim)
	{
	}

	protected bool PlayAnim(string strAnim, out float length)
	{
		length = default(float);
		return false;
	}

	private bool IsVailAnimEvent(string strAnim, string strEvt)
	{
		return false;
	}

	private bool IsVailAnimEvent(Animation anim, string strAnim, string strEvt)
	{
		return false;
	}

	private void InitCDN()
	{
	}

	private void InitEffectVFX()
	{
	}

	private void RefershFloorRewardBoxCdn()
	{
	}

	private void RefershDrawView()
	{
	}

	private void InitView()
	{
	}

	private void RefershCardView()
	{
	}

	private void RefershFloorRewardBox()
	{
	}

	private void OnClickDrawOneBtn()
	{
	}

	private void OnClickDrawFiveBtn()
	{
	}

	private void OnClickFloorRewardBoxBtn()
	{
	}

	private void OnClickFloorRewardPreviewBtn()
	{
	}

	private void OnClickJackpotBtn()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void CreateFloorRewardAppearEffect()
	{
	}

	private void CreateCardCombineAppearEffect()
	{
	}

	private bool CreateFloorFlyEffect()
	{
		return false;
	}

	private void OnRedPointCallback(object[] data)
	{
	}

	private void OnRecordCardSourceCallback(object[] data)
	{
	}

	private void OnExchangePopupWndCloseCallback(object[] data)
	{
	}

	private void OnCommonRewardWndFinishCallback(object[] data)
	{
	}

	private void OnFloorRewardReceiveCallback(object[] data)
	{
	}

	private void ExecuteFloorRewardAnim()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void OnEnterAnimDelayCallback()
	{
	}

	private void OnFloorRewardAppearAnimEndDelayCallback()
	{
	}

	private void OnFloorRewardReceiveAnimEndDelayCallback()
	{
	}

	private void OnFloorFlyEffectTweenFinished()
	{
	}

	private void OnFloorFlyFinishDelayCallback()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
