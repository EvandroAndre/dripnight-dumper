using System;
using GCommon;

namespace COW;

public class UIModelPerformance : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<string, uint> _003C_003E9__13_0;

		public static Converter<string, uint> _003C_003E9__13_1;

		internal uint _003CIsSettingAdviceNeedShow_003Eb__13_0(string s)
		{
			return 0u;
		}

		internal uint _003CIsSettingAdviceNeedShow_003Eb__13_1(string s)
		{
			return 0u;
		}
	}

	private bool m_IsPopup;

	private bool m_IsNeedEnergySaving;

	private PerformancePopUpType m_PopUpType;

	private string m_AdviceKey;

	public bool IsPopup
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsNeedEnergySaving
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public int GetPopUpType()
	{
		return 0;
	}

	public override void Logout(object[] data)
	{
	}

	public bool IsSettingAdviceNeedShow(float enterBattery, float leaveBattery)
	{
		return false;
	}

	public string GetAdviceKey()
	{
		return null;
	}

	private bool IsAdvisedBefore()
	{
		return false;
	}

	private bool IsNeedShowInHighFps()
	{
		return false;
	}

	private bool IsNeedShowInHighGraphicsQuality()
	{
		return false;
	}

	private float GetAdviceBatteryConsumption()
	{
		return 0f;
	}

	private bool IsNeedShowInHighBatteryConsumption(float enterBattery, float leaveBattery)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
