using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudFastPreviewController : UIBaseController
{
	protected UIHudFastPreviewView m_View;

	protected readonly string HudFastPreview;

	protected int m_PresetIndex;

	protected List<CustomHudItem> m_CustomHudList;

	protected float TableDeltaSpace;

	private const int m_PrefabContentPanelDepthOffset = 0;

	private const int m_PrefabChooseContainerDepthOffset = 1;

	private uint m_ChosenBGDelayCallId;

	protected float ToggleBGLength => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool DontDestroy()
	{
		return false;
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void ResetUIVisualState()
	{
	}

	private void CancelChosenBGDelayCall()
	{
	}

	protected virtual void ResetDefaultButtonBindings()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(int index = -1)
	{
	}

	protected virtual void ModifyViewSize()
	{
	}

	public void UpdatePanels(int depth)
	{
	}

	public int GetPanelsDepth()
	{
		return 0;
	}

	public virtual void RefreshHudView(object[] param)
	{
	}

	protected void RefreshPreviewHuds()
	{
	}

	protected void RefreshHudItemPosByConfig(HudConfigItem configData, CustomHudItem uiHudItem)
	{
	}

	protected void RefreshHudPos(int presetIndex, int garenadDir)
	{
	}

	protected void SetGrenadeBtnExpandDirection(int direction)
	{
	}

	protected void ChangeHudItemAnchor(string hudName, Transform uihudTrans, EUIAnchor anchor)
	{
	}

	private void OnCustomizeBtnClick()
	{
	}

	protected virtual void OnChooseBtnClick()
	{
	}

	protected virtual void ShowPopupMessage(string message)
	{
	}

	public virtual void RefreshChosenStates(bool showFX = false)
	{
	}

	protected virtual void RefreshChosenUIFX(bool show)
	{
	}

	private void _003CRefreshChosenStates_003Eb__32_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
