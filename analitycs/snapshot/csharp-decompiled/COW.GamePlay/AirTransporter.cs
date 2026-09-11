using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class AirTransporter : Entity, FDACAOPGNJK
{
	public class AirTransTweenRotation : UITweener
	{
		public Vector3 from;

		public Vector3 to;

		protected override void OnUpdate(float LLJBJNFLEJJ, bool GLKPHEMPOJB)
		{
		}
	}

	public Transform m_PassengerContainer;

	public Transform[] m_FlightPos;

	public Transform m_Model;

	public bool UseAnimationA;

	public GameObject DynamicLoadedNodeRoot;

	public string CustomizedSFXEngine;

	private AirtransportParams JJOLHADAOEH;

	private float GNBGDGKACJM;

	private Vector3 OKDNPBOKIME;

	private GameObject POFOHMBGLEG;

	private uint MEEDAHBLNJK;

	private Transform BHOOIJDBKFL;

	private PostEffectManager NGOFPFGGGDK;

	private GameObject OMGGDOLBFGF;

	private VisualInstanceHolder MFEFBCCCFLL;

	private bool OIHBFNINBLE;

	private bool NPJLCMFMCLH;

	private HashSet<BHGGAEEHJCO> GBJHDGLKJEK;

	private float FNCAHBPDMJC;

	private float HEJHEKKCKKB;

	private VisualInstanceHolder BFBLMEFAEMK;

	private uint LENFEHFMMEE;

	private float BDNMBFMENNO;

	private float AFAHHGCGFIM;

	private VisualInstanceHolder LLCPJLMKBGN;

	private VisualInstanceHolder DOPNAHGBHMC;

	private AirTransTweenRotation HHHPAELODIJ;

	private NBOrangeFoxAirTransporterAnim NLDEGMDEDCE;

	private bool EEPEKCJGOJA;

	protected override void OnAwake()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void MPPBNGGNNAN()
	{
	}

	public Vector3 GetCameraTrackableEntityPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		return default(Vector3);
	}

	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		return default(Quaternion);
	}

	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	public bool IsCameraTrackableEntityAlive()
	{
		return false;
	}

	public void SelectAirline(AirtransportParams NCBMHJLPCLF)
	{
	}

	public void SetOnBoard(Transform KDJNEHDAAFL)
	{
	}

	public void SetOnBoard(Player KDJNEHDAAFL)
	{
	}

	public void RefreshTeamFlightOnBoardPosition(PreviewTeamFlightView HOECOJGCDOG, int BDIFAEKCIED = 0)
	{
	}

	public void SetOffBoard(Transform KDJNEHDAAFL)
	{
	}

	public void TryGetOffBoard(Transform KDJNEHDAAFL)
	{
	}

	public void CancelDestroyAirtransportDelayCall()
	{
	}

	private void FICGBFNHGEC(float OKJIFBCMDAD)
	{
	}

	private void GEBIANLCNGM()
	{
	}

	private void AIAPHCMKHOE(float OKJIFBCMDAD)
	{
	}

	private void MHONLCENLLK()
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public Vector3 GetMovingVector()
	{
		return default(Vector3);
	}

	private void CDNPGHNDBIH()
	{
	}

	public bool IsInSuggestJumpRatio()
	{
		return false;
	}

	public bool IsOverSuggestJumpRatio()
	{
		return false;
	}

	public void UpdateSuggestJumpRatio(Vector3 HAFBBJILFBL)
	{
	}

	public bool IsForceToJump(BHGGAEEHJCO KJLFMPOFELA)
	{
		return false;
	}

	public bool CanJump()
	{
		return false;
	}

	public bool CanJump(float GOMNGFFGLKD)
	{
		return false;
	}

	public float CurRatio()
	{
		return 0f;
	}

	public AirtransportParams GetParam()
	{
		return null;
	}

	public void OnOpeningStart()
	{
	}

	public void OnOpeningEnd(object[] JCONDDPFBKK)
	{
	}

	private void NOPBLOCOOCL(bool AOOAGBBHDFA)
	{
	}

	public void FlightAnimSetGameCameraActive(bool AOOAGBBHDFA)
	{
	}

	private void EGFEAMKDPJM()
	{
	}

	public void TryReleaseBaseVFX()
	{
	}

	public void PlayAdditionalVFX(ResourceID GGMIDNEJGNO)
	{
	}

	public void TryReleaseAdditionalVFX()
	{
	}

	private void BLHCCKOJJBE()
	{
	}

	private void HLJBGFBNOEE(uint JCONDDPFBKK)
	{
	}

	private void PEGGNELPADD()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
