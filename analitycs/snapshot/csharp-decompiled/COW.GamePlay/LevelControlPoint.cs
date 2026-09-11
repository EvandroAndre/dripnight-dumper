using System;
using UnityEngine;

namespace COW.GamePlay;

public class LevelControlPoint : BaseLevelObject
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__18_0;

		internal void ODHONBKONJI()
		{
		}
	}

	public string ShowName;

	public GameObject m_EffectGO;

	protected bool FOMNLOHPJJJ;

	public const uint CONTROL_SCRAMBLE_TEAM_IDX = 3u;

	public const uint CONTROL_INVALID_TEAM_IDX = 0u;

	public Color[] EmptyStateColorArray;

	public Color[] LocalControlColorArray;

	public Color[] OppControlColorArray;

	public Color[] ScrambleColorArray;

	private UIModelMatch DIKAMAKALKB;

	private int OJEPOBEENEK;

	public bool IIHDHBEBIBM => false;

	protected override void OnStart()
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected virtual void ENOLBEDFMGM(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected virtual void LILIFMCBIJM(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	protected virtual void HJMLEPFAFNO(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	protected virtual void BHABJFKKCBA(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	protected virtual void JODPGFJIINH(byte EIOKHLKJEEL)
	{
	}

	protected virtual void JDCKAPHKPDN(byte EIOKHLKJEEL)
	{
	}

	protected void LINKEEPELOH(Color[] OBNGFCLDENO)
	{
	}

	protected virtual void HGHFGHGLILG(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
