using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class ActivityAwardDescription : UIActivityOperationController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<AwardDesc> _003C_003E9__21_0;

		internal bool _003CCreateAwards_003Eb__21_0(AwardDesc e)
		{
			return false;
		}
	}

	public UIButton OperateButton;

	public UISprite OperateWhite;

	public UISprite OperateGray;

	public UISprite OperateYellow;

	public UILabel OperateTitle;

	public UILabel Progress;

	public UIScrollView AwardScrollView;

	public UIGrid AwardGrid;

	public GameObject OperateGained;

	public UILabel OperateGainedLabel;

	public Animation ButtonAnimation;

	protected ClientActivityDesc m_Desc;

	protected UIModelActivity m_ModelActivity;

	private UIModelActivity.ActivityOperateStatus m_OperateStatus;

	protected bool m_Init;

	private List<UIStandardItemMiniController> m_CacheAwardList;

	public static ResourceID GetVFXResourceID()
	{
		return default(ResourceID);
	}

	protected virtual void BindOperate()
	{
	}

	protected void Start()
	{
	}

	public void SetData(ClientActivityDesc desc)
	{
	}

	protected virtual void SetOperateButtonUI()
	{
	}

	private void CreateAwards(List<AwardDesc> awards, bool big_prize)
	{
	}

	protected virtual void OnOperate()
	{
	}

	public void Reload()
	{
	}
}
