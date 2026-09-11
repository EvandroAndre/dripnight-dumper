using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UICommonSettingItemMultiSelectController : UICommonSettingItemBaseController
{
	private EMagicVoicePreviewResult m_MagicVoicePreviewResult;

	private List<UICommonSettingItemMultiSelectItemController> m_ItemList;

	private CommonSettingItemMagicVoiceData m_Data;

	private UICommonSettingItemMultiSelectView m_View;

	private UIModelVoice m_modelVoice;

	private const int BgMargin = 40;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnGameVoiceEngineInit(bool success)
	{
	}

	private void OnMagicVoiceInit(bool success)
	{
	}

	public override void SetViewData(CommonSettingItemDataBase data, int type)
	{
	}

	private void RefreshUI()
	{
	}

	public void OnSelectEffect(int effectId)
	{
	}

	private void OnMagicVoicePreviewResult(EMagicVoicePreviewResult result)
	{
	}

	protected virtual void UpdateBGWidth()
	{
	}

	private void RefreshBg()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void _003CSetViewData_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(CommonSettingItemDataBase P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
