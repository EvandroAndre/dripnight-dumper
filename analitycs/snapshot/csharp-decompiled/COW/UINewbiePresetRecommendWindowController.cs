using System.Collections.Generic;
using GCommon;

namespace COW;

public class UINewbiePresetRecommendWindowController : UIPopupWindowController
{
	private const int DEFAULT_ITEM_COUNT = 3;

	private UINewbiePresetRecommendWindowView m_View;

	private List<UINewbieRecPresetItemController> m_PresetItemList;

	private UIModelLoadout m_ModelLoadout;

	private List<NewbiePreset> m_DisplayPresetDataList;

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

	private uint GetCurrentPlayerLevel()
	{
		return 0u;
	}

	private void InitPresetItemList()
	{
	}

	private void ClearPresetItemList()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnConfirmPlanApplied()
	{
	}

	private void PlayNewbiePresetEquipEffect(int targetPlanIndex)
	{
	}

	private void PlayTrailEffectToEntrance()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
