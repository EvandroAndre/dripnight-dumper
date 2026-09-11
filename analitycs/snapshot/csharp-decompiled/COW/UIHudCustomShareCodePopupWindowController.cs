using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIHudCustomShareCodePopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum EBtnState
	{
		Disable,
		Enable,
		Loading
	}

	private UIHudCustomShareCodePopupWindowView m_View;

	private bool m_IsGenerateCodeWindow;

	private string m_ShareCodeUserName;

	private EBtnState m_BtnState;

	private int m_PresetIndex;

	private UIHudCustomController m_HudCtrl;

	private UIHudPreviewSettingController m_HudPreviewCtrl;

	private UIKolHudPopWndController m_KolHudPopCtrl;

	private int m_BackendGarenadeDir;

	private int m_BackendGarenadeDir2;

	private Dictionary<string, HudConfigItem> m_BackendShareCodeConfigs;

	private bool m_fromKolHudPopWnd;

	private byte[] m_HudSettings;

	private ulong m_ShareCodeAccountId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(UIBaseController baseCtrl, int presetIndex, bool isGenerateCodeWindow, string generatedSharedCode = null)
	{
	}

	public void SetDataWithError(UIBaseController baseCtrl, string errorkey, string inputText)
	{
	}

	private void OnTxtChanged()
	{
	}

	private void OnBtnClick()
	{
	}

	private void ShowDesc(bool isErrDesc, string key, string keyParam = null)
	{
	}

	private void SetCanInput(bool value)
	{
	}

	private void SetBtnState(EBtnState state)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void HandleUseHudSettingRes(CSUseHudSettingsShareCodeRes data)
	{
	}

	private void OnSensitivityBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
