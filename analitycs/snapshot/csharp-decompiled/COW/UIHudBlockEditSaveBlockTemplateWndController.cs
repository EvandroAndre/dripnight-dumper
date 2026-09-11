using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudBlockEditSaveBlockTemplateWndController : UIPopupWindowController
{
	private UIHudBlockEditSaveBlockTemplateWndView m_View;

	private Texture2D m_TemplateImage;

	private BlockData m_BlockData;

	private GraphData m_GraphData;

	private KCJDEKIJAKH m_TemplateData;

	private ESaveBlockTemplateType m_SaveType;

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

	public void SetViewData(Texture2D screenshot, BlockData blockData)
	{
	}

	private int GetTemplateIndex()
	{
		return 0;
	}

	public void SetViewData(BlockTemplateData blockTemplateData)
	{
	}

	private void OnNameInputSubmit()
	{
	}

	private void OnDescInputChange()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
