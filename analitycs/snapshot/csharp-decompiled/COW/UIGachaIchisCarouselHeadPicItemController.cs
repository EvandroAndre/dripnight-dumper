using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIGachaIchisCarouselHeadPicItemController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIGachaIchisCarouselHeadPicItemController _003C_003E4__this;

		public ulong accountId;

		internal void _003CFetchAccountInfoFromServer_003Eb__0(List<AccountInfoBasic> accountInfos)
		{
		}
	}

	private UIGachaIchisCarouselHeadPicItemView m_View;

	private UIModelFriends m_ModelFriends;

	private ulong m_AccountId;

	private const string ICHIS55_MYSTERY_AVATAR_RES_NAME = "FF_UI_Ichis_55_AvatatMystery";

	private List<UIWidget> m_DepthWidgets;

	private List<int> m_OriginalDepths;

	private int m_AppliedDepthOffset;

	private bool m_HasAppliedDepthOffset;

	public ulong AccountId => 0uL;

	public UIWidget MainWidget => null;

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

	public void SetData(ulong accountId)
	{
	}

	public void SetDefaultData()
	{
	}

	private void FetchAccountInfoFromServer(ulong accountId)
	{
	}

	private void ApplyAccountInfo(ulong accountId, AccountInfoBasic info)
	{
	}

	private void ApplyHeadPic(ulong accountId, uint headPicId, string externalIcon, EAccount.ExternalIconStatus iconStatus, EAccount.ExternalIconShowType iconShowType)
	{
	}

	private void OnAvatarAsyncReady(bool success)
	{
	}

	private void PrepareSpriteAvatarAnchor()
	{
	}

	public void SetAlpha(float alpha)
	{
	}

	public void ApplyDepthOffset(int offset)
	{
	}

	private void CacheDepths()
	{
	}

	private void MirrorAvatarToCircle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
