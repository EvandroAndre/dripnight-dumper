using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFourSymbolsHypeProcessBarController : UIBaseController
{
	private UIHudFourSymbolsHypeProcessBarView m_View;

	private List<UIFourSymbolsChooseItemController> m_CacheChooseItems;

	private MIMECDNNPEJ m_Game;

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

	private Dictionary<uint, FourSymbolSlider> m_SlidersInfo;

	private UISprite m_TargetSlider;

	private UICamera m_UICamera;

	private Camera m_Camera;

	private float m_HitDist;

	private const string CONDITION1NAME = "BtnFire";

	private const string CONDITION2NAME = "InventoryEntryContent";

	private bool m_IsTriggerBtnClick;

	private float m_LeftScreenWidth;

	private List<UILabel> m_CacheDescInfos;

	private bool m_IgnoreFirstIfReconnect;

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

	private void OnPlayerFourSymbolsSelectAttribute(object[] data)
	{
	}

	private void OnPlayerFourSymbolsPendingAttributeUpdate(object[] data)
	{
	}

	private void OnLevelUpBtnClick()
	{
	}

	private void ShowSelectAttributeView()
	{
	}

	private void OnLongPressBtn(bool isPress)
	{
	}

	private void ShowDetail(bool b)
	{
	}

	private void UpdateDescInfo()
	{
	}

	private void UpdateInfoBg()
	{
	}

	private void UpdateSliderInfo()
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

	private void OnHypeLevelChange(object[] data)
	{
	}

	private void OnMaxHypeValueChange(object[] data)
	{
	}

	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	private void OnSwitchObserver(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
