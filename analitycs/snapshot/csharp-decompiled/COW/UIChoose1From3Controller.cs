using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChoose1From3Controller : UIPreviewPopUpWindowController, IUIModelDataChangeObserver
{
	private UIModelIAPBundle m_ModelBundle;

	private UIModelActivity m_ModelActivity;

	private UIModelMall m_ModelMall;

	private UIChoose1From3View m_View;

	private UIRoot m_UIRoot;

	private uint m_ItemID;

	private List<UIChoose1From3ItemController> m_Items;

	private Transform[] m_ItemRoots;

	private OptionalBundleShowData m_CurData;

	private uint m_BundleID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void OnClickRecharge()
	{
	}

	public void OnClickClaim()
	{
	}

	private void UpdateView()
	{
	}

	private void SetItemID(OptionalBundleShowData data)
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void ShowPreview()
	{
	}

	private void SetPreviewInfo()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnCountDownEnd()
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
