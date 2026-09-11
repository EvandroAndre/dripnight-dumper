using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class CameraControllerManager : MonoBehaviour
{
	public enum GKMMBKHDOOI
	{
		Follow,
		VehicleDriver,
		VehiclePassenger,
		Skydiving,
		Death,
		Free,
		PendingRevive,
		Opening,
		NewDeath,
		FerrisWheel,
		SceneEdit,
		FreeFollow,
		LudoGame,
		UGCThirdPerson,
		UGCFirstPerson,
		UGCLookDown,
		UGCTwoDimension,
		UGCPerformance,
		UGCFree,
		ExecutionSkill,
		UGCObserver,
		UGCFirstPersonModel,
		SuperEmote,
		ForceTutorial,
		Scout,
		CameraModePhotoTemplate,
		UGCBasicCamera,
		CameraModeVideoTemplate,
		ActiveSkill,
		FreeView,
		ReplayTraceKill,
		CubicMap,
		FollowEmote,
		EmoteWithCameraAnim,
		FinalShot,
		ConstrainedFree,
		NinthStatue,
		NB
	}

	public delegate void OGBEHIGDBIN(int GJFJBMKPJNC, int IAPDGDIOIAL);

	public class LIBJDHDMOPF
	{
		public string EDBNBDIIJJA;

		public int BNJPACCMJEJ;

		public float DPMIFADBJMN;

		public LIBJDHDMOPF NMHOGPPPPJG()
		{
			return null;
		}
	}

	private Camera BAGLCCLIOEK;

	private Camera BENCPDLELBI;

	private BlackWhiteEffect HGKPFCMNJPO;

	private RoundnessFadeEffect BHLALMNBFJJ;

	private CameraControllerBase[] KKFMEGBCEJC;

	private GKMMBKHDOOI JHHPPAICOEH;

	private bool PIMFAHIFKNE;

	private GKMMBKHDOOI PKMEDEOGAEJ;

	private FDACAOPGNJK BMILPOPFBEJ;

	private OGBEHIGDBIN LMIMDLPKGDJ;

	private RenderUIToMainCam IMAGLEGJHFE;

	private float EPIOBIDIMHM;

	private float HKPIIGOLMPP;

	public float CameraModeBackOffsetCoefficient;

	public float CameraModeHeightOffset;

	private bool MCCOPKLMEBO;

	private int PBKNOKHFHBE;

	private bool FMBHLJACBJH;

	private LIBJDHDMOPF DHHDKLGDNOE;

	public Camera PDKBCPOIPKK => null;

	public void SetFarClipPlane(float FFNMDBKHFPF)
	{
	}

	public void ReSetFarClipPlane()
	{
	}

	public void SetFov(float FFADCBDFANJ)
	{
	}

	public void ReSetFov()
	{
	}

	public void SetlayerCullDistances(int PNLKPJNLDGB, float BAGMCFGCACD)
	{
	}

	public void SetlayerCullDistancesByName(string OAAGIOGANJA, float BAGMCFGCACD)
	{
	}

	public static bool IsUGCCareType(GKMMBKHDOOI CCNBNLAPJFM)
	{
		return false;
	}

	private void Awake()
	{
	}

	public bool SetCustomCullingMask(int CHFBIKBGGDD)
	{
		return false;
	}

	public void RestoreCullingMask()
	{
	}

	private void GAAKANCMFHC()
	{
	}

	private void DEMMIBIDHGO(object[] JCONDDPFBKK)
	{
	}

	private void GFDNPAPGKJD(object[] JCONDDPFBKK)
	{
	}

	private void CDIABFOLGGG(bool AJGDLBKCNDA)
	{
	}

	private void OnDestroy()
	{
	}

	private void EACKEAHAAMH()
	{
	}

	public void OpenEndSwtichSkydiving(Vector3 BMEBLGLGMNK, Quaternion PLDAMIJLPCH)
	{
	}

	public void Shutdown()
	{
	}

	public void RegistCameraChangedCallBack(OGBEHIGDBIN AMFIKBOBOIJ)
	{
	}

	public void UnRegistCameraChangedCallBack(OGBEHIGDBIN AMFIKBOBOIJ)
	{
	}

	private GKMMBKHDOOI LCBHNFJILCK(GKMMBKHDOOI JOPPBLMGMAB, ref FDACAOPGNJK FOFEHBEIMPP)
	{
		return GKMMBKHDOOI.Follow;
	}

	public bool IsCurExclusiveCameraController()
	{
		return false;
	}

	public void UnloadCurExclusiveCamera(GKMMBKHDOOI JOPPBLMGMAB)
	{
	}

	public void ChangeCameraToPrevious()
	{
	}

	public void ChangeCameraToFollow(bool NNHCGHPKMNN = false, Player PGEGMKJKOKI = null, bool IDCHCEECMBE = false, bool BEFKOIOPNFO = false)
	{
	}

	public void ChangeCamera(GKMMBKHDOOI JOPPBLMGMAB, bool NNHCGHPKMNN = false, FDACAOPGNJK FAOGFMGDCGF = null, bool IDCHCEECMBE = false, bool CJHAEFMBILG = false)
	{
	}

	public void ClearCurrentTargetEntity()
	{
	}

	public void ClearAllTargetEntity()
	{
	}

	public void SetCurrentTargetEntity(FDACAOPGNJK FOFEHBEIMPP)
	{
	}

	public T GetCameraController<T>(GKMMBKHDOOI JFBPNOCPDEJ) where T : CameraControllerBase
	{
		return null;
	}

	public CameraControllerBase CurrentCameraController()
	{
		return null;
	}

	public void ShowRebornModeBlackWhiteEffect()
	{
	}

	public void StopRebornModeBlackWhiteEffect()
	{
	}

	private void DKEEGGENOJM<T>(GKMMBKHDOOI JFBPNOCPDEJ) where T : CameraControllerBase
	{
	}

	public GKMMBKHDOOI GetCurrentECameraControllerType()
	{
		return GKMMBKHDOOI.Follow;
	}

	public GKMMBKHDOOI GetPreviousECameraControllerType()
	{
		return GKMMBKHDOOI.Follow;
	}

	public void OnCameraUpdated()
	{
	}

	public void CopyPostEffectToCamera(Camera HBJMHDIFCJO)
	{
	}

	public bool IsLookDownCtrlMode()
	{
		return false;
	}

	public bool IsTwoDimensionCtrlMode()
	{
		return false;
	}

	public void CacheServerCameraTransition(string GDDEBLAFLLG, int MHHBHGHGHPJ, float BOBNICBPCJK)
	{
	}

	public LIBJDHDMOPF GetCameraTransition()
	{
		return null;
	}
}
