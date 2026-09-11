using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIInvitationTipsBoxController : UIBaseController
{
	private UIInvitationTipsBoxView m_View;

	private UIModelInvitation m_ModelInvitation;

	private List<UIInvitationTipsBoxContentController> ContentList;

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

	private void HideInvitationTipsBox(object[] args)
	{
	}

	public bool IsInvitationDataOverMaxCnt(object[] args)
	{
		return false;
	}

	private bool IsfilteredInvitationData(object[] args)
	{
		return false;
	}

	private bool IsInHCGuideProcess()
	{
		return false;
	}

	public bool HasBlockingInvitationTipsBoxData()
	{
		return false;
	}

	private bool HasPendingBlockingInvitationData()
	{
		return false;
	}

	public void SetUIData()
	{
	}

	private void Expired(object[] args)
	{
	}

	private void ResetContentDepth()
	{
	}

	private bool CheckData(object[] args)
	{
		return false;
	}

	public void GetUIData(out object[] data, out ulong time, out ulong id)
	{
		data = null;
		time = default(ulong);
		id = default(ulong);
	}

	public void PeekUIData(out object[] data)
	{
		data = null;
	}

	private void OnExpired(object[] args)
	{
	}

	private void AddContent(UIInvitationTipsBoxContentController content)
	{
	}

	private void RemoveContent()
	{
	}

	public void GroupInviteBlock(object[] arg)
	{
	}

	public void GroupJoinBlock(object[] arg)
	{
	}

	public List<CachedInvitationData> GetCurrentDisplayingInvitationsForCache()
	{
		return null;
	}

	public void CloseAllForCache()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
