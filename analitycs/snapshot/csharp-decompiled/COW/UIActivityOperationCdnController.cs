using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityOperationCdnController : UIBaseController
{
	protected struct OperationCdnGo
	{
		public GameObject gameObject = null;

		public GameObject OperateWhite = null;

		public GameObject OperateGray = null;

		public GameObject OperateYellow = null;

		public UILabel OperateTitle = null;

		public GameObject OperateGained = null;

		public UILabel OperateGainedLabel = null;

		public UINetworkTexture GotoCdn = null;

		public UINetworkTexture ClaimCdn = null;

		public UINetworkTexture IncompleteCdn = null;

		public string GotoUrl = null;

		public string ClaimUrl = null;

		public string IncompleteUrl = null;

		public GameObject TimeLockIcon = null;

		public UILabel TimeCountTitle = null;

		public bool HasSeparateCountdownDisplay => false;

		public OperationCdnGo(GameObject go, GameObject operateWhite, GameObject operateGray, GameObject operateYellow, UILabel operateTitle, GameObject operateGained, UILabel operateGainedLabel, UINetworkTexture gotoCdn, UINetworkTexture claimCdn, UINetworkTexture incompleteCdn, string gotoUrl, string claimUrl, string incompleteUrl, GameObject timeLockIcon = null, UILabel timeCountTitle = null)
		{
		}
	}

	protected void ResetOperateStatus(OperationCdnGo go)
	{
	}

	protected void HideCountdownDisplay(OperationCdnGo go)
	{
	}

	protected void UpdateCountdownDisplay(OperationCdnGo go, ulong startTime)
	{
	}

	protected void SetNotStartStatus(OperationCdnGo go)
	{
	}

	protected void SetNotStartCountdownStatus(OperationCdnGo go, ulong startTime)
	{
	}

	protected void SetGoToStatus(OperationCdnGo go)
	{
	}

	protected void SetUnClaimableStatus(OperationCdnGo go)
	{
	}

	protected void SetClaimableStatus(OperationCdnGo go)
	{
	}

	protected void SetClaimedStatus(OperationCdnGo go)
	{
	}

	protected void SetExpiredStatus(OperationCdnGo go)
	{
	}

	protected void SetCompleteStatus(OperationCdnGo go)
	{
	}

	protected static void TryApplyCdn(UINetworkTexture tex, string url, GameObject fallbackOperate = null)
	{
	}

	protected static void HideCdn(UINetworkTexture tex)
	{
	}

	protected static bool IsActivityGroupInPreviewPeriod(UIModelActivity model, uint templateGroupId, uint fallbackGroupId)
	{
		return false;
	}
}
