using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityOverviewItem : MonoBehaviour
{
	public UIButton GoToBtn;

	public UINetworkTexture AD;

	public GameObject Tag;

	public UILabel TagLabel;

	public UISprite TagIconBg;

	public UISprite TagIcon;

	public GameObject RedPoint;

	public UIButton BG;

	public UIDragScrollView UIDragView;

	public UILabel BtnLabel;

	public UICountDownLabel CountDownLable;

	public GameObject CountDownRoot;

	public GameObject CountDownIcon;

	public UITable CountDownTable;

	private ClientActivityDesc m_ActivityDesc;

	private UIModelActivity m_ActivityModel;

	private string m_CategoryTitle;

	public void Init()
	{
	}

	public void SetCategoryTitle(string title)
	{
	}

	public void SetViewData(ClientActivityDesc desc)
	{
	}

	private void RefreshOverviewItem()
	{
	}

	private void SetGotoBtn()
	{
	}

	public void Reload()
	{
	}

	private void OnShowActivityTime()
	{
	}

	private void OnOutShowPeriod()
	{
	}

	public void SetScrollView(UIScrollView scrollView)
	{
	}

	private void OnGoToClick()
	{
	}

	private bool IsActivityRewardedAndHide()
	{
		return false;
	}

	private void SendBannerClickLog(uint id)
	{
	}
}
