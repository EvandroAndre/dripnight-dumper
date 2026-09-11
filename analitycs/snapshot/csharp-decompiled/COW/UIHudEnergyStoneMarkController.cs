using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudEnergyStoneMarkController : UIHudNameBaseController
{
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public EnergyStoneMarkScore score;

		public List<EnergyStoneMarkScore> socreList;

		internal void _003CShowScoreChange_003Eb__0()
		{
		}
	}

	private List<EnergyStoneMarkScore> m_ScoreList;

	private const uint MYTEAMARROWCOLOR = 1188691967u;

	private const uint OPPOTEAMARRORCOLOR = 4065856511u;

	private UIHudEnergyStoneMarkView m_View;

	private BHGGAEEHJCO m_BindPlayerID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPlayer(BHGGAEEHJCO pID)
	{
	}

	private bool IsSameOrLeftTeam(BHGGAEEHJCO pID)
	{
		return false;
	}

	private void SetArrowColor(Color color)
	{
	}

	protected override bool NeedShowDistance()
	{
		return false;
	}

	protected override bool NeedKeepInScreen()
	{
		return false;
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedShowOutScreenAllow()
	{
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private Vector3 GetRefPos(Player p)
	{
		return default(Vector3);
	}

	protected override Vector2 GetWidgetBound()
	{
		return default(Vector2);
	}

	private void OnPlayerScoreChange(object[] param)
	{
	}

	private void ShowScoreChange(int scoreValue, byte scoreRegion, bool isLeftTeam)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedShowOutScreenAllow()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		return default(Vector2);
	}
}
