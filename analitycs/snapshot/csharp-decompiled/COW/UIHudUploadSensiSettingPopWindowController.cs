using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudUploadSensiSettingPopWindowController : UIPopupWindowController
{
	private UIHudUploadSensiSettingPopWindowView m_View;

	private CommonSettingContentData m_Data;

	private UICommonSettingContentShortController m_Ctrl;

	private Dictionary<uint, float> m_OriginalSensitivitySettings;

	private Dictionary<uint, float> m_WorkingSensitivitySettings;

	private HudUploadInfoItem m_HudUploadInfoItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(HudUploadInfoItem hudUploadInfoItem)
	{
	}

	private Dictionary<uint, float> ConvertArrayToDict(float[] array)
	{
		return null;
	}

	private float[] ConvertDictToArray(Dictionary<uint, float> dict)
	{
		return null;
	}

	private void OnCloseBtnClick()
	{
	}

	private bool DictEqual(Dictionary<uint, float> dict1, Dictionary<uint, float> dict2)
	{
		return false;
	}

	private void SaveSensitivityData()
	{
	}

	private void InitSensitivityUI()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private float GetSensitivityValue(SensiSettingKey key)
	{
		return 0f;
	}

	private void SetSensitivityValue(SensiSettingKey key, float value)
	{
	}

	private UIKolSensiSettingSlider CreateSensitivityData()
	{
		return null;
	}

	private UIKolSensiSettingSlider Createx1ScopeData()
	{
		return null;
	}

	private UIKolSensiSettingSlider Createx2ScopeData()
	{
		return null;
	}

	private UIKolSensiSettingSlider Createx4ScopeData()
	{
		return null;
	}

	private UIKolSensiSettingSlider Createx8ScopeData()
	{
		return null;
	}

	private UIKolSensiSettingSlider CreateAuxAimSensitivityData()
	{
		return null;
	}

	private float GetMinusValue()
	{
		return 0f;
	}

	private float GetPlusValue()
	{
		return 0f;
	}

	private void _003COnCloseBtnClick_003Eb__13_0()
	{
	}

	private void _003COnCloseBtnClick_003Eb__13_1()
	{
	}

	private float _003CCreateSensitivityData_003Eb__20_0()
	{
		return 0f;
	}

	private void _003CCreateSensitivityData_003Eb__20_1(float value)
	{
	}

	private float _003CCreatex1ScopeData_003Eb__21_0()
	{
		return 0f;
	}

	private void _003CCreatex1ScopeData_003Eb__21_1(float value)
	{
	}

	private float _003CCreatex2ScopeData_003Eb__22_0()
	{
		return 0f;
	}

	private void _003CCreatex2ScopeData_003Eb__22_1(float value)
	{
	}

	private float _003CCreatex4ScopeData_003Eb__23_0()
	{
		return 0f;
	}

	private void _003CCreatex4ScopeData_003Eb__23_1(float value)
	{
	}

	private float _003CCreatex8ScopeData_003Eb__24_0()
	{
		return 0f;
	}

	private void _003CCreatex8ScopeData_003Eb__24_1(float value)
	{
	}

	private float _003CCreateAuxAimSensitivityData_003Eb__25_0()
	{
		return 0f;
	}

	private void _003CCreateAuxAimSensitivityData_003Eb__25_1(float value)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
