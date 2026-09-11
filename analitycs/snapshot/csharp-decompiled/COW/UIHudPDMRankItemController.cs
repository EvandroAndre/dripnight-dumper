using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPDMRankItemController : UIBaseController
{
	private UIHudPDMRankItemView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private int m_Rank;

	private Color m_GrayColor;

	private float m_EndAniTime;

	private uint[] m_Infos;

	private MutableString m_TextBuilder;

	public float EndAnimTime => 0f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetPlayer(BHGGAEEHJCO playerID)
	{
	}

	public void SetRank(int rank)
	{
	}

	public BHGGAEEHJCO GetPlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	public uint[] GetPlayerInfo()
	{
		return null;
	}

	public void SetColorWithSelfRank(int selfRank)
	{
	}

	public void RefreshViewData()
	{
	}

	public void SetSelf()
	{
	}

	public void StartPlaySelfAnim(bool up)
	{
	}

	public void StopPlaySelfAnim()
	{
	}

	public void PlayEndAnim()
	{
	}

	public void PlayResetAnim()
	{
	}

	public void PlayFirstRankAnim()
	{
	}

	private float GetEndAnimTime()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
