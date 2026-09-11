using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UISparkPetLevelDetailPopupWindowController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public uint currentLevel;

		internal bool _003CUpdateLevelDisplay_003Eb__0(SparkLevelAwardDesc x)
		{
			return false;
		}
	}

	private UISparkPetLevelDetailPopupWindowView m_View;

	private UIModelSparkPet m_ModelSparkPet;

	private List<SparkLevelAwardDesc> m_LevelAwardList;

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

	private void SetLobbySocialInputEnable(bool enable)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void ScrollToCurrentLevel()
	{
	}

	private void InitView()
	{
	}

	private void RefreshView()
	{
	}

	private void UpdateSparkPetDisplay()
	{
	}

	private void PrepareDataList()
	{
	}

	private void UpdateLevelDisplay()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
