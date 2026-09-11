using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW.HUD;

internal class UIHudSafeZoneInfoController : UIBaseController
{
	public const uint VISIBILITY_STATE_EighthLand = 1073741824u;

	public const uint VISIBILITY_STATE_SeafoodLittleGirlGame = 536870912u;

	public const uint VISIBILITY_STATE_GB_GPGulag = 268435456u;

	private UIHudSafeZoneInfoView m_View;

	private SafeZone m_SafeZone;

	private bool m_UseStringBuilder;

	private StringBuilder m_Timer;

	private MutableString m_Timer1;

	private MutableString m_Timer2;

	private string Lable_Stable;

	private string Lable_PreShrink;

	private string Lable_Shrink;

	private string Lable_Warning;

	private string Sprite_Stable;

	private string Sprite_PreShrink;

	private string Sprite_Shrink;

	private uint m_TimeLength;

	private uint mSeconds;

	private uint min;

	private uint sec;

	private bool m_IsInSafeZone;

	private bool m_IsPrevOneMinuteCount;

	private bool m_IsOneMinuteCount;

	private bool m_IsPrevInSafeZoneDuringShrink;

	private bool m_IsInSafeZoneDuringShrink;

	private uint m_DelayCallID;

	private bool m_UpdateWarningTipsForMode;

	private static readonly Color YELLOW;

	private static readonly Color RED;

	private static readonly Color WarnColor;

	private ESafeZoneModeSetting m_ZoneMode;

	protected uint STACKICON_VISIBLE;

	protected uint AFFIX_POPUP_VISIBLE;

	protected BitArrayBoolean m_SafeZoneVisibility;

	private AJBNNHJDOEK m_LastSpanType;

	private string Metropolis_Area_Open;

	private uint m_MetropolisAreaID;

	private uint m_MetropolisAreaState;

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

	private void RefreshTeammateEighthIcon(uint PlayerID, uint iconType)
	{
	}

	private void RefreshEightInLandState()
	{
	}

	private void Update()
	{
	}

	private void SetUIData()
	{
	}

	private bool CheckNeedHideSelf(SafeZone.ZoneDefinition zoneStatus)
	{
		return false;
	}

	private static void AppendMinOrSec(StringBuilder sb, uint min)
	{
	}

	private void UpdateSafeZone()
	{
	}

	private void OnMetropolisAreaLocalPlayerEnter(object[] param)
	{
	}

	private void OnMetropolisAreaStateChange(object[] param)
	{
	}

	private void UpdateMetropolisAreaInfo()
	{
	}

	private void UpdateWarningTips()
	{
	}

	private void OnSettingChange(object[] data)
	{
	}

	private void DisplayUAVMiniTips(float time)
	{
	}

	private void DisableUAVMiniTips()
	{
	}

	private void OnUavCreate(object[] data)
	{
	}

	private void OnUavReveal(object[] data)
	{
	}

	private void OnUavDestroy(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void UpdateRootActive()
	{
	}

	private void OnAffixPopupShow(bool value)
	{
	}

	private void ShowHideZoneInfo(bool value)
	{
	}

	private void OnSeaFoodLittleGirlHudVisibleChange(bool value)
	{
	}

	private void UpdateLabelInfo()
	{
	}

	private void ShowTutorialCountDown(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
