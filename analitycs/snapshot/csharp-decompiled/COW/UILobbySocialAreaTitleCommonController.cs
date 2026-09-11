using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILobbySocialAreaTitleCommonController : UIBaseController
{
	private UILobbySocialAreaTitleCommonView m_View;

	private Vector3 m_TitleLabelPosDefault;

	private VisualInstanceHolder m_VFXHolder;

	private ESocialHall.TitleType m_CurrentTitleType;

	private BHGGAEEHJCO m_VFXPlayerID;

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

	public void SetViewData(uint id, BHGGAEEHJCO vfxPlayerID)
	{
	}

	private void SetViewData(SocialLobbyTitleData data, BHGGAEEHJCO vfxPlayerID)
	{
	}

	public void ClearTitle()
	{
	}

	private void PlayVFX()
	{
	}

	private ResourceID GetLobbyLWTitleVFXResourceID(UIModelLobbySocial modelLobbySocial)
	{
		return default(ResourceID);
	}

	private void OnSocialHallTitleUpdate(uint type)
	{
	}

	private void ReleaseVFX()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
