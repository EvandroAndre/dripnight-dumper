using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelRateAPPSwitch : UIBaseModel
{
	private class ModeRankRequirement
	{
		private uint m_Mode;

		private uint m_Rank;

		public ModeRankRequirement(uint mode, uint rank)
		{
		}

		public bool IsRequirementMeet(uint mode, uint rank)
		{
			return false;
		}
	}

	private const string SHOW_RATEAPP_POPUP_DAYOFYEAR_KEY = "SHOW_RATEAPP_POPUP_DAYOFYEAR";

	private bool m_Ready;

	private uint m_Cooldown;

	private List<ModeRankRequirement> m_Requirements;

	public bool IOSOpen;

	public bool GPOpen;

	public bool HuaweiOpen;

	public bool ThirdPartyOpen;

	public void ProcessRateAppSwitch(CSGetRateAppSwitchRes data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	private bool CanRateApp()
	{
		return false;
	}

	private int GetPopupDayOfYear()
	{
		return 0;
	}

	private bool IsPopupCooldownFinished()
	{
		return false;
	}

	public void SetPopupDayOfYear()
	{
	}

	public bool IsRateAppAvailable(MatchStats matchStats)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
