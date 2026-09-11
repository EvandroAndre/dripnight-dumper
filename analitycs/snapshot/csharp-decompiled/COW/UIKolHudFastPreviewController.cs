using System;
using GCommon;
using proto;

namespace COW;

public class UIKolHudFastPreviewController : UIHudFastPreviewController
{
	protected Action m_BackButtonClickAction;

	protected bool m_ShowChosen;

	protected bool m_IsKolItem;

	private UIModelKolHud m_ModelKolHud;

	protected float m_BGLength;

	private int m_Depth;

	public int PanelDepth => 0;

	public void RegistBackButtonClick(Action action)
	{
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public new static bool DontDestroy()
	{
		return false;
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public void OpenKolPreviewGreyBG()
	{
	}

	protected override void OnUIInit()
	{
	}

	public void SetKolViewData(KolHudDetail itemData)
	{
	}

	public void SetShareCodeViewData(KolHudDetail itemData, float BGLength = 1500f)
	{
	}

	public void SetSelecetKolItem(int index = -1, float BGLength = 700f)
	{
	}

	public void SetViewDataForPreview(int index = -1, float BGLength = 700f)
	{
	}

	private void ModifyKolViewSizeByBGLength(float BGLength)
	{
	}

	private void ModifyKolViewSize()
	{
	}

	private void OnBackButtonClick()
	{
	}

	public void RefreshKolHudView()
	{
	}

	public override void RefreshHudView(object[] param)
	{
	}

	public void SetKolItemData(KolHudDetail itemData)
	{
	}

	public void SetSelectHudBtnClickEvent()
	{
	}

	protected override void OnChooseBtnClick()
	{
	}

	protected virtual void RefreshKolHudPos(KolHudDetail itemData)
	{
	}

	private void RefreshPreviewHudPosByToggleIdx(int toggleIdx)
	{
	}

	public void RefreshChosenStates(bool showFX = false, bool isHudUpload = false)
	{
	}

	public void SetSelectHudBtnClickEvent(EventDelegate.Callback callback)
	{
	}

	public void SetSelectHudBtnActive(bool active)
	{
	}

	public new bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshHudView(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnChooseBtnClick()
	{
	}
}
