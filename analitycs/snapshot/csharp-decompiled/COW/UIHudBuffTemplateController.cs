using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudBuffTemplateController : UIBaseController
{
	private UIHudBuffTemplateView m_View;

	public BountyPickupStatus BountyStatus;

	private float m_TotalLife;

	private float m_CurrentLife;

	private ABCOGCNHJAD m_BuffEffect;

	private MFHOLGEKNLI _003CBuffBevTypeID_003Ek__BackingField;

	public ulong BuffHUDDataUID;

	private bool m_IsShowingNextNum;

	private VisualInstanceHolder m_VfxHolder;

	private bool m_GunBuffValue;

	private bool m_IsLeftGunBuff;

	public MFHOLGEKNLI BuffBevTypeID
	{
		get
		{
			return _003CBuffBevTypeID_003Ek__BackingField;
		}
		set
		{
			_003CBuffBevTypeID_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShowCustomVFX(object[] data)
	{
	}

	private void OnShowCustomVFXByUID(GEvent gEvent)
	{
	}

	public void ShowCustomVFXByHUDUID(PBMECFKJKFO hudVFXData, bool isForce)
	{
	}

	private void HideShowCustomVFXByHUDUID()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetUIData(OAICFPKEJNE bevData)
	{
	}

	public void SetUIDataFromBuffHUDData(AMGDCBACIBH hudData, CDKLBIDALAC updateInfo = null)
	{
	}

	public void UpdateChildCount(List<AMGDCBACIBH> childBuffHudData)
	{
	}

	public void UpdateLayers(uint level)
	{
	}

	public void UpdateLifeTime(float life)
	{
	}

	public void UpdateCDTime(float leftTime, float durationTime = 0f)
	{
	}

	public void SetTipsEffect(bool active)
	{
	}

	public void SetBuffEffect(ABCOGCNHJAD buffEffectDurationType)
	{
	}

	public void HideReset()
	{
	}

	public bool IsBuffShow()
	{
		return false;
	}

	public void PlayBuffEffectOnce()
	{
	}

	private void UpdateCDProgress()
	{
	}

	private void Update()
	{
	}

	private void OnPress(GameObject ob)
	{
	}

	public void SetGunBuff(bool gunBuff, bool isLeftGunBuff)
	{
	}

	private void OnShowEnergyStoneBuffTutorial(object[] parma)
	{
	}

	private void OnShowMatchStartBuffTutorial(object[] parma)
	{
	}

	public void SetNextNum(int num)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
