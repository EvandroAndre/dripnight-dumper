using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassSeparatorController : UIBaseController, UITable2.IUITable2Item
{
	private UIBooyahPassSeparatorView m_View;

	protected UIModelBooyahPass m_ModelBooyahPass;

	private BooyahPassRewardItemData m_Data;

	private const string BOOYAHPASS_MAIN_LOG = "BooyahPassMain";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ShowHighLight(object[] data)
	{
	}

	private void RefreshView(object data, int index)
	{
	}

	private void BtnCycleRewardClick()
	{
	}

	private void ClaimRewardByID()
	{
	}

	private void ShowPreview(uint index)
	{
	}

	private void BtnPrivilegeOnClick()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
