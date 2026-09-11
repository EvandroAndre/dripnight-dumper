using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDLLMChatMessageItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIHUDLLMChatMessageItemView m_View;

	private LLMMessageInfo m_LLMMessageInfo;

	private bool isSelf;

	private int BannerOffsetX => 0;

	private int BannerOffsetY => 0;

	public Bounds bounds => default(Bounds);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(LLMMessageInfo info)
	{
	}

	private void InitView()
	{
	}

	private void RefreshLayoutView(bool isSelf)
	{
	}

	private void RefreshContentView(LLMMessageInfo info, bool isSelf, bool isloading)
	{
	}

	private void AdjustChatTable2Layout(GameObject view, bool isSelf)
	{
	}

	private void OnBannerClick()
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
