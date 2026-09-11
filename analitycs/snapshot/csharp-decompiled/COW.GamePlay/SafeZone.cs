using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class SafeZone : Entity
{
	[Serializable]
	public class ZoneDefinition
	{
		public int stageID;

		public Vector3 OuterCenter;

		public float OuterRadius;

		public Vector3 InnerCenter;

		public float InnerRadius;

		public AJBNNHJDOEK TimeSpanType;

		public uint StartTime;

		public uint EndTime;

		public bool QuickPreShrink;

		public bool IsPhaseRandomCenter;

		public bool UsingZone;

		public FJPNELGACKJ OuterZone;

		public FJPNELGACKJ InnerZone;

		public float MiniMapScale;

		public bool DHGKKOJINGO(Vector3 HDFILHFDBKB)
		{
			return false;
		}

		public Vector3 HFAPHFNNHDO()
		{
			return default(Vector3);
		}

		public float FOEJEPNAJEB()
		{
			return 0f;
		}

		public float IBAIGDJAFCC()
		{
			return 0f;
		}

		public bool CPANNCCHLGB()
		{
			return false;
		}

		public bool FALKOFKFLDD()
		{
			return false;
		}
	}

	private class FFPDEHNHOGL
	{
		private enum KJHAAJKEGFD
		{
			None,
			Low,
			Medium,
			High
		}

		private uint PCAMILBCHAJ;

		private uint CGANAEGANAB;

		private uint JECPAAFIBKF;

		private uint CFOHPIPGMPC;

		private List<GameObject> PAAGNHFEEFH;

		private CommonParticleEffect DNGMEDBHPAM;

		private KJHAAJKEGFD KFPHNJPPBPH;

		public bool APPMGCENIFG => false;

		public FFPDEHNHOGL(ResourceID MCPHCMDJGDD, ResourceID NGLIFKLOKLH, ResourceID IENCDKPGFKK, ResourceID HFBKNOIBOLI)
		{
		}

		private void BBJKINBFMPB(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
		{
		}

		private CommonParticleEffect LAFEEBPGIIG(GameObject KGJNMPHDKAB, bool MMMMFOJKOOF)
		{
			return null;
		}

		public void NEOENBJNFGG()
		{
		}

		public void CLIFGLOLLOO(int DOAHFGKLIDC)
		{
		}

		public void CHAOIPNPPPH()
		{
		}

		public void DCBKFKBIPAC()
		{
		}

		private void ILCEEGGBEJK(uint JPEHNBCECBD, ResourceID LAKJAMPOIFA, GameObject BOMJKCLNOKO)
		{
		}
	}

	public class CLGEFLMMOJJ
	{
		public uint NDOBEEBIIAP;

		public Vector3 GCFLDJMCFHN;

		public uint NKAIJOJBONE;

		public Vector3 IEDDJBJKJIE;

		public Vector3 CMONLMFBFLB;
	}

	public byte SafeZoneMaxIndex;

	private GameObject FDPCFPICAHE;

	private Renderer NNCNENLLPII;

	private float EPPIHMNBGKH;

	private bool CMPCFKMPKJM;

	private int NGIKLFCONMD;

	public float TexMaxEffectLimitRadius;

	public float TexMaxEffectRatio;

	public float TexMinEffectLimitRadius;

	public float TexMinEffectRatio;

	private int PCICGENCGIH;

	private int PHKKPKIFCKG;

	private float MONEHPGNLGG;

	public const uint ISVISIBLE_FLOATINGLAND = 1u;

	public const uint ISVISIBLE_SAPLAND = 2u;

	public const uint ISVISIBLE_FINALSHOT = 4u;

	protected BitArrayBoolean CNELANECFHO;

	private ZoneDefinition DCPDCFOPNLA;

	public bool ShowingRectZone;

	public float CurrentRadius;

	public float CurrentLength;

	public float CurrentWidth;

	public Vector3 CurrentForward;

	private bool OCNCDIOOENM;

	public bool EnableSafeZoneDamage;

	public float SafeZoneHeight;

	public float HeightScaleForRect;

	private FFPDEHNHOGL MJLLELGNCDF;

	private BloodType FBBDBNBMDAL;

	private BitArrayBoolean LLCBCILFAGC;

	private const uint PJECAELBMIJ = 1u;

	private const uint CFKAMBIKPLP = 2u;

	private bool LEDKPECEFHM;

	private Dictionary<uint, CLGEFLMMOJJ> GABMADGFKBE;

	private List<CLGEFLMMOJJ> DJPLHKMBKKG;

	private Dictionary<uint, GameObject> IJDMMGKDPMD;

	private AudioResource EBFNEFPNJNM;

	private static readonly int BPCAIOFDJNP;

	private int NOHPPNKKDGI;

	private int IKKIGAKPADD;

	private bool BDNJDICFAGG;

	private bool NGMFEEOMNAI;

	private uint EANCLNEBBFJ;

	private uint GKCNMANIBBE;

	private uint CIDNOMANAIK;

	public bool CDFLCICPLKI => false;

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public ZoneDefinition GetSafeZoneStatus()
	{
		return null;
	}

	private void KGGGELPKGAG()
	{
	}

	protected void FFPKOEKFMMO()
	{
	}

	private void DNOPENPIAPI()
	{
	}

	protected void GEAMJHAJJDC(bool PAKBGNMPNEH)
	{
	}

	public bool IsLocalPlayerOrObserverTargetIgnoreSafeZone()
	{
		return false;
	}

	public bool IsZoneDamageEffectShowing()
	{
		return false;
	}

	protected bool PANHAIDCPMH()
	{
		return false;
	}

	private void DMGJNAMBAOE()
	{
	}

	protected bool AOCDIPNELOL()
	{
		return false;
	}

	protected virtual void LANPFBJPEFA()
	{
	}

	private ResourceID CLGCBNFCCCH()
	{
		return default(ResourceID);
	}

	private void GHILMHAHBCJ()
	{
	}

	public bool IsZoneActive()
	{
		return false;
	}

	public bool IsSafePosition(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public float Get2DDistanceToSafeZoneEdge(Vector3 HDFILHFDBKB)
	{
		return 0f;
	}

	public float GetDistanceToInnerCenterEdge(Vector3 HDFILHFDBKB)
	{
		return 0f;
	}

	public float Get2DSqrMagnitudeToSafeZoneCenter(Vector3 HDFILHFDBKB)
	{
		return 0f;
	}

	public bool ShowWarning(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public bool IsInInnerPosition(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public bool IsLocalPlayerInInnerSafePosition()
	{
		return false;
	}

	public bool IsLocalPlayerInSafePosition()
	{
		return false;
	}

	public void InitByMessage(CMCDHCMJGFK APHHNHEDHKD)
	{
	}

	public void InitByMessage(KJEDIABALBP APHHNHEDHKD)
	{
	}

	private void JDIMFMOCLBJ(bool BIOKICLFENK)
	{
	}

	public void InitAllGamezoneMessage(GFCAJNPKNJA APHHNHEDHKD)
	{
	}

	public void InitBombZoneMessage(OLOACOCJKGC APHHNHEDHKD)
	{
	}

	public List<CLGEFLMMOJJ> GetBombZoneInfos()
	{
		return null;
	}

	public int BombZoneIndexAtPosition(Vector3 IGDHIDGLOKG)
	{
		return 0;
	}

	public void UpdateBombZoneEffect(uint EGGCODOFOMF, bool MGNNDOFDFCC)
	{
	}

	public Dictionary<uint, CLGEFLMMOJJ> GetGameZoneInfoMap()
	{
		return null;
	}

	public CLGEFLMMOJJ GetCurrentGameZoneInfo()
	{
		return null;
	}

	public CLGEFLMMOJJ GetGameZoneInfoByIndex(uint NIBBKONKPHP)
	{
		return null;
	}

	public ZoneDefinition getZoneStatus()
	{
		return null;
	}

	public bool IsInRebornFinal()
	{
		return false;
	}

	public bool IsRebornFinalStart()
	{
		return false;
	}

	public new void Hide()
	{
	}

	public void Destory()
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	public void InitVFX()
	{
	}

	public void SetVFXEnable(bool HCLGHJNEFIC)
	{
	}

	public void SetVisible(uint PIDINBNGILH, bool NDGMENGEGIE)
	{
	}

	public void UpdateAlphaScale(float DCAGDCEBHEP)
	{
	}

	public void RestoreDefaultAlphaScale()
	{
	}

	private void DLHPBGLJNFK(object[] DJAPBCKDFKA)
	{
	}

	private void FEEDFCFGEIH()
	{
	}

	public void CheckBRShowFFWSEffect()
	{
	}

	public void CheckCSShowFFWSEffect()
	{
	}

	private void PCIKINDBDMH()
	{
	}

	private void HCIGMPGBMFI()
	{
	}

	private void NMDJAGDGKCM()
	{
	}

	private void OHBNABGHPKO(AJBNNHJDOEK LEJJDFJBEJC)
	{
	}

	private void IFNCLNMMLNA(GEvent EDDIMPKJIGM)
	{
	}

	private void FCJKONAGJAG()
	{
	}

	private void MODBPILNHOD(uint JPEHNBCECBD, ResourceID LAKJAMPOIFA, GameObject BOMJKCLNOKO)
	{
	}

	private void DPAEKEEJDJJ(uint JPEHNBCECBD, ResourceID LAKJAMPOIFA, GameObject BOMJKCLNOKO)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
