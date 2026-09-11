using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class AirtransportParams : MonoBehaviour
{
	public class JKBJJFDHGFM
	{
		public float FDAJAKBDJEF;

		public float HNPKPHHGGMA;
	}

	public class HAFBNIAOJKP
	{
		public float FDAJAKBDJEF;

		public ResourceID PKAMLFOIACC;
	}

	public enum BDBNLBEPKGM
	{
		RankedMatch,
		CasualMatchNormal,
		CasualMatchNewbie
	}

	private class OIFOKPDINDC : IComparer<JKBJJFDHGFM>
	{
		public int Compare(JKBJJFDHGFM FADOEDJHAGD, JKBJJFDHGFM LJJDHJOELML)
		{
			return 0;
		}
	}

	private class ADBCINGACAL : IComparer<HAFBNIAOJKP>
	{
		public int Compare(HAFBNIAOJKP FADOEDJHAGD, HAFBNIAOJKP LJJDHJOELML)
		{
			return 0;
		}
	}

	public Transform InnerSphere;

	public Transform OuterSphere;

	public float EndJumpDeltaMin;

	public float StartJump;

	public float EndJump;

	public float EndJumpMin;

	public float EndJumpMax;

	public float Duration;

	public bool IsCurve;

	public Vector3 Center;

	public float YOffset;

	public float YFallingParam;

	public float CenterOffsetParam;

	public float AirLineLength;

	public float AirlineOffsetParam;

	public Vector2 Airline_X_VectorInWorld;

	public Vector2 Airline_Z_VectorInWorld;

	public bool ShowDragon;

	public float DragonBeginRadio;

	public float DragonEndRadio;

	public float DragonAppearOffset;

	public float DragonBeginYOffset;

	public float DragonEndYOffset;

	public Vector3 DragonBeginLocalPosition;

	public Vector3 DragonEndLocalPosition;

	private List<JKBJJFDHGFM> OJMDJMPJFPC;

	private List<HAFBNIAOJKP> OAJPDCNFOGG;

	private List<HAFBNIAOJKP> BPOJPGOKHFM;

	public BDBNLBEPKGM MatchType;

	private Dictionary<BHGGAEEHJCO, float> JIOMNBMBMHP;

	private Vector3 LFGGDMHABFO;

	private Vector3 FGIKGINGKEC;

	public Vector3 LMAEGPEAECO => default(Vector3);

	public Vector3 ELECEGLAPPC => default(Vector3);

	public Vector3 GetStartJumpWorldPos()
	{
		return default(Vector3);
	}

	public Vector3 GetStartJumpMapPos()
	{
		return default(Vector3);
	}

	public Vector3 GetEndJumpWorldPos()
	{
		return default(Vector3);
	}

	public Vector3 GetEndJumpMapPos()
	{
		return default(Vector3);
	}

	public Vector3 GetAircraftMapLocalAngles(float GOMNGFFGLKD)
	{
		return default(Vector3);
	}

	public Vector3 GetAircraftMapLocalPos(float CECGLOHKLLL)
	{
		return default(Vector3);
	}

	public void TrySetupSpeedUpData()
	{
	}

	public float GetFixedRatio(float CECGLOHKLLL)
	{
		return 0f;
	}

	public HAFBNIAOJKP GetCurSpeedUpVFXData(float CECGLOHKLLL)
	{
		return null;
	}

	public HAFBNIAOJKP GetCurSpeedUpUIFXData(float CECGLOHKLLL)
	{
		return null;
	}

	public float GetEndJumpRatio(BHGGAEEHJCO KJLFMPOFELA)
	{
		return 0f;
	}

	public void SetStartPosition(Vector3 HDFILHFDBKB)
	{
	}

	public void SetEndPosition(Vector3 HDFILHFDBKB)
	{
	}

	public void CalcCurveParam()
	{
	}

	public Vector3 GetAirLineWorldPositionByRatio(float GOMNGFFGLKD)
	{
		return default(Vector3);
	}

	public float GetAirLineRollAngleByRatio(float GOMNGFFGLKD)
	{
		return 0f;
	}

	public bool CanShowDragon(float FLLLDOFFBPD)
	{
		return false;
	}

	public void CalcDragonParam()
	{
	}

	public Vector3 GetDragonLocalPositionByRatio(float CGOOBKEIPJL)
	{
		return default(Vector3);
	}

	public void Init(Vector3 OCLFLNINDAP, Vector3 BMEBLGLGMNK, Vector3 LMOGBFCEONO, int PGGNBLCFLPD, float MEFAFJOHFEN, float LDACDCBHKBB, float CNKMEPFCJOM, bool ADDJGAIIMLD, float AMMJFOGCOBG, float IKIHALDIANH, float LIKNKFDJLEH, bool JMLNBACEILE, List<float> KBGNHLKEDBD)
	{
	}
}
