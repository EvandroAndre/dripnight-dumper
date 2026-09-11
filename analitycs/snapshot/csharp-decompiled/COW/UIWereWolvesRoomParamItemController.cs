using System;
using GCommon;
using message;

namespace COW;

internal class UIWereWolvesRoomParamItemController : UIBaseController
{
	private UIWereWolvesRoomParamItemView m_View;

	private uint m_CurParamValue;

	private JEMFGANHOPH m_ParamType;

	private Action<JEMFGANHOPH, uint> m_ParamChangeCallBack;

	private WereWolvesRoomSettingData m_SettingData;

	private uint CurParamValue
	{
		get
		{
			return 0u;
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

	public void InitSettingData(JEMFGANHOPH paramType, WereWolvesRoomSettingData settingData, Action<JEMFGANHOPH, uint> callBack)
	{
	}

	public void UpdateCurParam(uint param)
	{
	}

	public void ResetMin(uint param)
	{
	}

	private void OnClickMin()
	{
	}

	private void OnClickMax()
	{
	}

	private void OnClickPlus()
	{
	}

	private void OnClickSub()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
