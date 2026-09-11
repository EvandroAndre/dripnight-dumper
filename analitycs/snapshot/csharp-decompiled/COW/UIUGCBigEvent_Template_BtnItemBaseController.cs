using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCBigEvent_Template_BtnItemBaseController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private const string CUSTOM_EVENT_ENTRANCE_ENTERED_KEY = "CustomEvent{0}_EntranceType{1}/Priority{2}/Entered_{3}";

	public CustomEventEntranceDesc Data;

	protected UIModelBigEventTemplate m_UIModelBigEventTemplate;

	protected UIButton EntranceBtn;

	protected UINetworkTexture BubbleTexture;

	protected GameObject GoBubble;

	protected UINetworkTexture IconTexture;

	protected UILabel BubbleLabel;

	protected TweenScale PeakDayBubbleShake;

	protected UISprite SpriteRedDot;

	protected UILabel TitleLabel;

	protected UINetworkTexture TextureRedDot;

	protected UINavigationUtil.UINavigationFrom From;

	protected Transform EffectRoot;

	protected GameObject m_RedDotGameObject;

	protected ResourceID m_EffectVFXResID;

	protected GameObject m_EffectVFXGO;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

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

	protected override void OnUIDestroy()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual void OnClickBtn()
	{
	}

	public void SetData(CustomEventEntranceDesc data)
	{
	}

	private bool IsCheckEnteredNeeded(EBigEventTemplateInPageEntranceType entranceType)
	{
		return false;
	}

	protected virtual void OpenPeakDayPopupWnd()
	{
	}

	protected virtual void OpenMissionPopupWnd()
	{
	}

	protected virtual void RefreshViewInternal()
	{
	}

	private void RefreshPeakDayBubble()
	{
	}

	protected virtual void RefreshMissionRedPoint()
	{
	}

	private void RefreshExchangeStoreRedPoint()
	{
	}

	private void RefreshNotEnteredRedPoint()
	{
	}

	private void InitRedDotShowState()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public virtual void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
