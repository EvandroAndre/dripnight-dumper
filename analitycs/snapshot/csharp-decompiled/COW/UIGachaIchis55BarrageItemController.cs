using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIGachaIchis55BarrageItemController : UIBarrageItemBaseController
{
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIGachaIchis55BarrageItemController _003C_003E4__this;

		public ulong accountId;

		public ESharedGacha.RareType tier;

		internal void _003CFetchAndSetAccountInfo_003Eb__0(List<AccountInfoBasic> accountInfos)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UIGachaIchis55BarrageItemController _003C_003E4__this;

		public ulong currentAccountId;

		internal void _003CApplyHeadPic_003Eb__0(bool success)
		{
		}
	}

	private const string BIG_PRIZE_VFX_RES_ID = "UIFX_Ichis_55_BigPrize";

	private const string NORMAL_PRIZE_VFX_RES_ID = "UIFX_Ichis_55_Prize";

	private UIGachaIchis55BarrageItemView m_View;

	private UIModelIchis m_ModelIchis;

	private UIModelFriends m_ModelFriends;

	private uint m_ChestId;

	private ulong m_AccountId;

	private ulong m_SelfAccountId;

	private bool m_IsSelf;

	private ResourceID m_BigPrizeVFXResourceID;

	private ResourceID m_NormalPrizeVFXResourceID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool SetBarrageData(BarrageData data)
	{
		return false;
	}

	private void OnBarrageBtnClick()
	{
	}

	public override void OnReachDestination()
	{
	}

	public override void Hide()
	{
	}

	private void FetchAndSetAccountInfo(ulong accountId, ESharedGacha.RareType tier)
	{
	}

	private void SetDefaultHeadIcon(ulong accountId)
	{
	}

	private void SetHeadIcon(ulong accountId, AccountInfoBasic accountInfo)
	{
	}

	private void ApplyHeadPic(ulong currentAccountId, uint headPicId, ulong dataAccountId, string externalIcon, EAccount.ExternalIconStatus iconStatus, EAccount.ExternalIconShowType iconShowType)
	{
	}

	private void OnAvatarAsyncReady(ulong accountId, bool success)
	{
	}

	private void MirrorAvatarToCircle()
	{
	}

	private void SetPlayerName(string displayName, ESharedGacha.RareType tier)
	{
	}

	private void SetItemInfo(uint chestId, uint chestSubId, uint uniqueId, ESharedGacha.RareType tier, BarrageTier barrageLevel)
	{
	}

	private void SetTierStyle(ESharedGacha.RareType tier, BarrageTier barrageLevel)
	{
	}

	private void PlayPrizeVFX(bool isBigPrize)
	{
	}

	private void StopPrizeVFX()
	{
	}

	private ResourceID GetPrizeVFXResourceID(bool isBigPrize)
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnReachDestination()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
