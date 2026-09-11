using GCommon;
using UnityEngine;

namespace COW;

public class UIHudQuickChatContainerView : UIBaseView
{
	public UIScrollView ScrollView;

	public UITable MessageListTable;

	public QuickChatView ChatMessageInstance;

	public UISprite ListBG;

	public GameObject ThumbTimesNode;

	public GameObject NormalThumbTimes;

	public GameObject MaxThumbTimes;

	public UILabel ThumbTimes;

	public GameObject TeamListInfoNode;

	public Transform CSLikeThumbPos;

	public Transform BRLikeThumbPos;

	public Transform QuickChatThumbPos;

	public UIAnchor CenterAnchor;

	public GameObject MutliClickEffect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
