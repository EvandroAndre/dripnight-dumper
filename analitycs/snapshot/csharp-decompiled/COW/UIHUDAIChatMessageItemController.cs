using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDAIChatMessageItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIHUDAIChatMessageItemView m_View;

	private AIMessageInfo m_AIMessageInfo;

	private int BannerOffset;

	private List<UIHUDAIChatUGCSetParamItemController> m_UIHUDAIChatUGCSetParamItems;

	private const int m_PopupMenuDepth = 859;

	public Bounds bounds => default(Bounds);

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(AIMessageInfo info, bool isTemp)
	{
	}

	private void RefreshFastChatView()
	{
	}

	private void RefreshFastChatContent()
	{
	}

	private void RefreshFastChatTable2Layout()
	{
	}

	private void InitView()
	{
	}

	private void RefreshLayoutView(bool isSelf)
	{
	}

	private void RefreshUGCContentView(AIMessageInfo info, bool isTemp)
	{
	}

	private void ExcuteParamsModify()
	{
	}

	private void RefreshContentView(AIMessageInfo info, bool isSelf, bool isLoading)
	{
	}

	private void RefreshVoteView(bool isSelf, bool showVoteButton, bool isLike, bool isDisLike)
	{
	}

	private void OnNoLikeIconClick()
	{
	}

	private void OnNoDislikeIconClick()
	{
	}

	private void RefreshLikeState(bool isLike, bool isDislike)
	{
	}

	private void AdjustChatTable2Layout(GameObject view, bool isSelf)
	{
	}

	private void OnBannerClick()
	{
	}

	private void OnFastChat1Click()
	{
	}

	private void OnFastChat2Click()
	{
	}

	private void OnExcuteClick()
	{
	}

	private void CopyToClipBoard(object content)
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
