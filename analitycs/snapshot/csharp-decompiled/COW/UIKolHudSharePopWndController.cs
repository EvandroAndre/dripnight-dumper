using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIKolHudSharePopWndController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__20_0;

		internal void _003COnClickUseButton_003Eb__20_0()
		{
		}
	}

	private UIKolHudSharePopWndView m_View;

	private UIKolHudFastPreviewController m_HudFastPreviewController;

	private byte[] m_HudSettings;

	private string m_PlayerName;

	private ulong m_PlayerId;

	private UIKolHudPopWndController m_KolHudPopWndCtrl;

	private bool m_UseSensitivity;

	private KolHudDetail m_DetailData;

	private EUIKolHudShareOpenSource m_OpenSource;

	private EHudShareGetSource m_HudGetSource;

	private int m_PresetIndex;

	private UIModelKolHud m_ModelKolHud;

	private UIHudPreviewSettingController m_HudPreviewCtrl;

	private UIHudCustomController m_HudCtrl;

	private Dictionary<string, HudConfigItem> m_BackendShareCodeConfigs;

	private int m_BackendGarenadeDir;

	private int m_BackendGarenadeDir2;

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

	private void OnClickUseButton()
	{
	}

	private void OnPreviewSensivityEntranceClick()
	{
	}

	private void OnPreviewHudClick()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnUseSensitivityChange()
	{
	}

	public void SetQRWindowFromPreview(byte[] hud_settings, string playerName, ulong player_id, UIKolHudPopWndController kolHudPopWndCtrl, int presetIndex = 0, EUIKolHudShareOpenSource openSource = EUIKolHudShareOpenSource.Preview)
	{
	}

	internal void SetQRWindowController(UIHudPreviewSettingController hudPreviewCtrl, UIHudCustomController hudCtrl, Dictionary<string, HudConfigItem> backendShareCodeConfigs, int backendGarenadeDir, int backendGarenadeDir2)
	{
	}

	public void SetHudShareGetSource(EHudShareGetSource source)
	{
	}

	public void SetQRWindowData(byte[] hud_settings, string playerName, ulong player_id, UIKolHudPopWndController kolHudPopWndCtrl, EUIKolHudShareOpenSource openSource = EUIKolHudShareOpenSource.Kol)
	{
	}

	private void _003COnClickUseButton_003Eb__20_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
