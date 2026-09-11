using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFlagBattleHypeProcessBarController : UIBaseController
{
	public class FlagBattleSlider
	{
		public byte Camp;

		public UISprite SliderSpr;

		public GameObject EffectGo;

		public ParticleSystem ParticleSys;

		public FlagBattleSlider(byte camp, UISprite sliderSpr)
		{
		}
	}

	protected UIHudFlagBattleHypeProcessBarView m_View;

	private List<UIFlagBattleChooseItemController> m_CacheChooseItems;

	private KBGPKGCDHAP m_Game;

	private ushort m_CurrentHypeValue;

	private ushort m_LastHypeValue;

	private ushort m_MaxHypeValue;

	protected ushort m_CurrentHypeLevel;

	private ushort m_MaxHypeLevel;

	private float m_HypeChangeProcess;

	private const int m_SliderChangeSpeed = 3;

	private const float m_HypeValueChangedPassedTime = 2f;

	private bool m_HypeValueHadChanged;

	private float m_Timer;

	private const float m_hypeValPerLevel = 1000f;

	private bool m_HasInitSelectItemCnt;

	private bool m_IsPress;

	private bool m_IsShowDetail;

	private Color m_DefaultFullColor;

	private ResourceID m_DefaultSliderFullEffect;

	private ResourceID m_DefaultLevelupAudioEffect;

	private ResourceID m_LevelMaxAudioEffect;

	private Dictionary<uint, FlagBattleSlider> m_SlidersInfo;

	private UISprite m_TargetSlider;

	private UICamera m_UICamera;

	private Camera m_Camera;

	private float m_HitDist;

	private const string CONDITION1NAME = "BtnFire";

	private const string CONDITION2NAME = "InventoryEntryContent";

	private bool m_IsTriggerBtnClick;

	private float m_LeftScreenWidth;

	private Vector3 LevelUpBtnOrginalPos;

	private Vector3 LevelUpBtnFourPos;

	private List<UILabel> m_CacheDescInfos;

	private bool m_IgnoreFirstIfReconnect;

	protected bool IsShowDetail
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected Dictionary<uint, FlagBattleSlider> SlidersInfo => null;

	public bool HadHypeValueChanged
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void Update()
	{
	}

	private void UpdateProcess()
	{
	}

	private void UpdateTouchInfo()
	{
	}

	private void UpdateLongPressInfo()
	{
	}

	private bool CheckPCTouch(Vector3 pos)
	{
		return false;
	}

	private bool CheckMobileTouch()
	{
		return false;
	}

	private bool CheckPos(Vector2 pos)
	{
		return false;
	}

	private void OnMeetTouchCondition()
	{
	}

	private void UpdateTargetSlider()
	{
	}

	private void InitSelectItem(int cnt)
	{
	}

	private void InitSlider()
	{
	}

	private void OnHudCustomizeSettingChanged(object[] data)
	{
	}

	private void OnPlayerFourSymbolsSelectAttribute(object[] data)
	{
	}

	private void OnPlayerReviveShowBuffUI(object[] data)
	{
	}

	private void OnPlayerFourSymbolsPendingAttributeUpdate(object[] data)
	{
	}

	protected virtual void OnLevelUpBtnClick()
	{
	}

	private void ShowSelectAttributeView()
	{
	}

	private void OnLongPressBtn(bool isPress)
	{
	}

	protected virtual void ShowDetail(bool b)
	{
	}

	private void UpdateDescInfo()
	{
	}

	protected virtual void ShowHypeDesc(Dictionary<byte, uint> data)
	{
	}

	private void UpdateInfoBg()
	{
	}

	protected virtual void UpdateSliderInfo()
	{
	}

	protected void ShowSliderSprEffect(FlagBattleSlider sliderInfo)
	{
	}

	protected void ResetSliderSprEffect(FlagBattleSlider sliderInfo)
	{
	}

	protected virtual void ShowSliderLvInfo(Dictionary<byte, uint> selectedAtt)
	{
	}

	protected void RefreshForPlayer(ushort curHypeValue, ushort maxHypeValue, ushort curHypeLv, ushort maxHypeLv)
	{
	}

	private void ShowSliderValueChange(float progress)
	{
	}

	private void ShowHypeChangeEffect(bool isIncreasing)
	{
	}

	private void RefreshHypeValueState()
	{
	}

	private void OnHypeValueChange(object[] data)
	{
	}

	protected virtual void OnHypeLevelChange(object[] data)
	{
	}

	private void OnMaxHypeValueChange(object[] data)
	{
	}

	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	protected virtual void OnSwitchObserver(object[] data)
	{
	}

	public void UpdateFSModePos(float y)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
