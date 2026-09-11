using GCommon;
using UnityEngine;

namespace COW;

public class UIActivityOperationController : UIBaseController
{
	protected struct OperationGo(GameObject go, GameObject OperateWhite, GameObject OperateGray, GameObject OperateYellow, UILabel OperateTitle, GameObject OperateGained, UILabel OperateGainedLabel)
	{
		public GameObject gameObject = null;

		public GameObject OperateWhite = null;

		public GameObject OperateGray = null;

		public GameObject OperateYellow = null;

		public UILabel OperateTitle = null;

		public GameObject OperateGained = null;

		public UILabel OperateGainedLabel = null;
	}

	protected GameObject m_OperateWhite;

	protected GameObject m_OperateGray;

	protected GameObject m_OperateYellow;

	protected UILabel m_OperateTitle;

	protected GameObject m_OperateGained;

	protected UILabel m_OperateGainedLabel;

	protected virtual void ResetOperateStatus()
	{
	}

	protected virtual void SetNotStartStatus()
	{
	}

	protected virtual void SetGoToStatus()
	{
	}

	protected virtual void SetUnClaimableStatus()
	{
	}

	protected virtual void SetClaimableStatus()
	{
	}

	protected virtual void SetClaimedStatus()
	{
	}

	protected virtual void SetExpiredStatus()
	{
	}

	protected virtual void SetCompleteStatus()
	{
	}

	protected virtual void ResetOperateStatus(OperationGo go)
	{
	}

	protected virtual void SetNotStartStatus(OperationGo go)
	{
	}

	protected virtual void SetGoToStatus(OperationGo go)
	{
	}

	protected virtual void SetUnClaimableStatus(OperationGo go)
	{
	}

	protected virtual void SetClaimableStatus(OperationGo go)
	{
	}

	protected virtual void SetClaimedStatus(OperationGo go)
	{
	}

	protected virtual void SetExpiredStatus(OperationGo go)
	{
	}

	protected virtual void SetCompleteStatus(OperationGo go)
	{
	}
}
