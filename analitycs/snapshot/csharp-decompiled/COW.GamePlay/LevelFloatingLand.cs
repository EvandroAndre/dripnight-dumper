using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelFloatingLand : BaseLevelObject
{
	private class BIJFNMICEHB
	{
		public Player PGEGMKJKOKI;

		public Vector3Int MFNLOIIOAAM;
	}

	public static readonly int ReviveByOtherMode;

	public static readonly Color Color_1;

	public static readonly Color Color_2;

	public static readonly Color Color_3;

	public static readonly Color Color_4;

	public static readonly Color Color_5;

	public static readonly Color UIColor_1;

	public static readonly Color UIColor_2;

	public static readonly Color UIColor_3;

	public static readonly Color UIColor_4;

	public static readonly Color UIColor_5;

	public static readonly ResourceID Color_Broken_Effect_1;

	public static readonly ResourceID Color_Broken_Effect_2;

	public static readonly ResourceID Color_Broken_Effect_3;

	public static readonly ResourceID Color_Broken_Effect_4;

	public static readonly ResourceID Color_Broken_Effect_5;

	public static readonly int CloseTipTime;

	public static readonly int EndCountdownTime;

	public static readonly int SuccessLeaveWaitTime;

	public static readonly int ReviveTime;

	public static readonly int DrumRebornDuration;

	private ResourceID[] HEGHLMOMOJP;

	private ColorLandDrawHelper PEIADDMNEEP;

	private Dictionary<uint, BIJFNMICEHB> DBBKBFGIGLF;

	public Camera MiniMapCamera;

	private float CMAIFBNLGCN;

	private bool KGAMHIFNMLP;

	public uint CurrTeamProgressValue;

	public int CurrTeamTimeDuration;

	public int CurrTeamEndTime;

	public int ActiveTime;

	private bool HJHPCCCFCCK;

	public static bool CanReviveByOther()
	{
		return false;
	}

	public static ResourceID GetEffectByColorIndex(int CDKAAILILEL)
	{
		return default(ResourceID);
	}

	public static Color GetColorByIndex(int CDKAAILILEL)
	{
		return default(Color);
	}

	public static Color GetUIColorByIndex(int CDKAAILILEL)
	{
		return default(Color);
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	protected override void OnAwake()
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void PGMEFDGHOMA()
	{
	}

	private void ABDJAFPKCND()
	{
	}

	public void Init()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public void OnJoinFloatingLand(uint KJLFMPOFELA, byte CDKAAILILEL)
	{
	}

	public void OnLeaveFloatingLand(uint KJLFMPOFELA)
	{
	}

	public void ColorDraw(int FADOEDJHAGD, int LJJDHJOELML, int AOHMEHFCHJN, int NJMGFOAPCGA, byte MENGFBOEHEJ)
	{
	}

	public void ColorDrawByIndex(int NIBBKONKPHP, int NJMGFOAPCGA)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}
}
