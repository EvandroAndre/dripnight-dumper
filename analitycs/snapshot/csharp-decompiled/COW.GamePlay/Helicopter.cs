using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal class Helicopter : Vehicle, VehicleControllerInterface
{
	private enum GEPFPEIKMMD
	{
		Loop,
		Start,
		MoveLow,
		MoveHigh,
		AutoDwon,
		Upper
	}

	private sealed class APIAIEJMKJO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Helicopter KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public APIAIEJMKJO(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class OCNJHLEOJMB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public int KGDHLKPJAMI;

		private int AKIGPHODLIO;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public OCNJHLEOJMB(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class IECKCIIPJPP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		private int AKIGPHODLIO;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public IECKCIIPJPP(int CBPPJACCGOH)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Transform ModelTrans;

	public float ForwardSpeed;

	public float BackwardSpeed;

	public float UpSpeed;

	public float DownSpeed;

	public float AutoDownSpeed;

	public float TurnTiltSpeed;

	public float ForwardTiltSpeed;

	public float BackwardTiltSpeed;

	public float TiltRecoverSpeed;

	public float RideHeight;

	private float BPPEIOMALBI;

	private int KGLODOCHKPN;

	public float MaxPosDownThreshold;

	public float JoyXAngleThreshold;

	public float JoyThreshold;

	public float JoyTurnAngleThreshold;

	public float TurnSpeed;

	public int EngineForce;

	public int EngineUpThreshold;

	public int EngineDownThreshold;

	private Vector2 AOMEDHDCEKH;

	private float PAGFAJDDHJD;

	private float MFNBHBJGOFO;

	private Vector2 KCNHCIIOMAD;

	public bool IsOnGround;

	private Vector3 BDINLPKILII;

	private GameObject[] DBMDECCKEDN;

	public Vector3 CameraEulerAngleOffset;

	public float DriverCameraHeight;

	public float DriverCameraDist;

	public float DriverCameraLerp;

	public LevelCannon[] CannoArray;

	private float OIJKILCPOMI;

	private GameObject[] JOPNDKJGCMA;

	private bool AODAOKGALPO;

	private Coroutine BKENKGOKCBC;

	private GMPGMPFNMFP GLDGGAEAFKC;

	private float NPJHICNKAPJ;

	private uint KNNKIBAMJBJ;

	private GameObject OMCDNOEEDGC;

	private float INFMDCILIIB;

	public GameObject EatBuffCollider;

	private Vector3 FGGKFEOIBFH;

	private bool EEDLICFNDED;

	public WheelCollider FrontLeftWheelCollider;

	public WheelCollider FrontRightWheelCollider;

	public WheelCollider RearLeftWheelCollider;

	public WheelCollider RearRightWheelCollider;

	private bool CAFCLPBNDCH;

	private int DICCFMJPIBO;

	public bool NJNPAJDNMEI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NANDHBHCEHO => false;

	public float JEKAJGBHPGL => 0f;

	public float AAPGPMPKMBD => 0f;

	public float EOONEBKLFFG => 0f;

	public float DEBMKOBDPHC => 0f;

	public float HNDHIFGGPDK => 0f;

	public int AIGPMFLKHLC => 0;

	public bool NJHEMAJLAMM => false;

	public float CNDLPFDAFEF => 0f;

	bool VehicleControllerInterface.AIBFGEOIPCD
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform CCEJKFHBMAB => null;

	public VehicleControllerInfo DIGLGAPOMOP => null;

	protected override void OnAwake()
	{
	}

	public override void SetVehicleData(GKEDHMFHDFM JCONDDPFBKK, VehicleConfigData DKLKGHGFNCC, int HHLLCKFNHPM)
	{
	}

	public void OnGetOutCannon(object[] JCONDDPFBKK)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void SyncVehicleStable(bool BAGNKAKIOFJ)
	{
	}

	public bool IsLocalPlayer()
	{
		return false;
	}

	public void SetEngineForce(int PNBCCLOBJPN, int EIOKHLKJEEL)
	{
	}

	private IEnumerator EIHJALEDDCL()
	{
		return null;
	}

	public void SetPilotMode(byte PNBCCLOBJPN, byte EIOKHLKJEEL)
	{
	}

	public override byte GetCurrentPackedOp()
	{
		return 0;
	}

	private void HJKNBFMFAEB()
	{
	}

	private void NECGJNPOPKG()
	{
	}

	private IEnumerator OEOEIBBLHAC(int KGDHLKPJAMI)
	{
		return null;
	}

	private IEnumerator EMDCBDKFBHE()
	{
		return null;
	}

	private void CFBJKJJBHHC(string DGDDJLEOPBL, float MNKGICOFEPC = 2f)
	{
	}

	public void SetFlyState(bool OKLLIEFDNPN, bool IDCHCEECMBE = false)
	{
	}

	private void FOCMDGKPOOO(float HOGHEFNINAE)
	{
	}

	private void IOPFGKGBBKD(float HOGHEFNINAE)
	{
	}

	protected override void BHIMKPGOPIP(bool HCLGHJNEFIC)
	{
	}

	protected override void BMMODHKDMFN(bool DCAPIHJMMBL)
	{
	}

	public override void SetupCamera(VehicleDriverCamera NJMENHHJHCJ)
	{
	}

	private void GBIBDFAEBBI(bool BDCGHOECKAK)
	{
	}

	public void SetTrigger()
	{
	}

	public void GetConfigPara()
	{
	}

	public void DebugFill()
	{
	}

	private void HBOHGDALLJF()
	{
	}

	public override bool SetSeat(int KEMBBPMADFD, BHGGAEEHJCO NDGDFMDIGLC)
	{
		return false;
	}

	public override void SetPassergerWeapon(int OIMPDJMNOFC, BHGGAEEHJCO MJBAGNLEIIL)
	{
	}

	protected override void HDNBCDEPLHP(Dictionary<string, VehicleControllerInfo> BIBGOPMGFDC)
	{
	}

	private float ICCKPGOIBHM()
	{
		return 0f;
	}

	public void ResetPlayerTransformInCannon()
	{
	}

	public float CaculateVehicleRevs()
	{
		return 0f;
	}

	public void BindVehicleSkin(VehicleSkinInfoBase HDIFMBJLEJC)
	{
	}

	private void EFPMALCDKFA(GEPFPEIKMMD CCNBNLAPJFM)
	{
	}

	private void KAMKLLOICCG(GEPFPEIKMMD CCNBNLAPJFM, bool GPFPIAMCEMI, float LMOHOKJLCJC = 1f)
	{
	}

	private void KFMAFFOJEMP()
	{
	}

	public void SetControllerInfo(VehicleControllerInfo GNLIAKMGDDG)
	{
	}

	public void SetVehicleEnable(bool AOOAGBBHDFA, bool KKKHNJPPGNC = false)
	{
	}

	public void SetMaxSpeedScale(float GLPLIHEECAP)
	{
	}

	public float GetCurrentMaxSpeed()
	{
		return 0f;
	}

	public float GetCurrentMaxHighYSpeed()
	{
		return 0f;
	}

	public void SetDriverSpeedScale(float GLPLIHEECAP)
	{
	}

	public float GetDriverSpeedScale()
	{
		return 0f;
	}

	public void LockMaxSpeed(float IMKNJGHAHPI)
	{
	}

	public void UnLockMaxSpeed()
	{
	}

	public void UpdateVehicleSpeed(float IFGACJFFEGC, float KMFMICABCFL)
	{
	}

	public void UpdateVehicleSteerAngle(float FGLFEJPBFOD)
	{
	}

	public void VehicleLazyFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void VehicleLasyUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void VehicleUpdateInput(bool NCPIMBDABPG, bool FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	public void VehicleUpdateInput(float NCPIMBDABPG, float FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	public void KillEngine()
	{
	}

	public void StartEngine()
	{
	}

	public int GetWheelType(GameObject CLACOPMJHDI)
	{
		return 0;
	}

	public void StartBoost(float OMOJGCCJFLO, float LLNANNNALIE, float AOOCNKPILEO, bool MPMKADBEBCJ = false)
	{
	}

	public void StopBoost()
	{
	}

	public void SetJumpHeightRate(float JAMCOPNBGFD)
	{
	}

	public void SetHightSpeedSteerAngleRate(float JAMCOPNBGFD)
	{
	}

	public void SetEngineTorqueRate(float JAMCOPNBGFD)
	{
	}

	public void SetBrakeTorqueRate(float JAMCOPNBGFD)
	{
	}

	public float GetEngineTorqueRate()
	{
		return 0f;
	}

	public float GetBrakeTorqueRate()
	{
		return 0f;
	}

	public void ForceStop()
	{
	}

	public override void Explode(float JPMIGELCCDF)
	{
	}

	private void IJKAKOJNEMF()
	{
	}

	public bool IsInWall()
	{
		return false;
	}

	protected override void JCBIGCIKIPB()
	{
	}

	protected override void FIHCLADPPAF()
	{
	}

	public override string GetIconInMap()
	{
		return null;
	}

	public override bool IsLimitTimeUsage()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_SetVehicleData(GKEDHMFHDFM P0, VehicleConfigData P1, int P2)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncVehicleStable(bool P0)
	{
	}

	public byte _003C_003EiFixBaseProxy_GetCurrentPackedOp()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_BHIMKPGOPIP(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_BMMODHKDMFN(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetupCamera(VehicleDriverCamera P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_SetSeat(int P0, BHGGAEEHJCO P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SetPassergerWeapon(int P0, BHGGAEEHJCO P1)
	{
	}

	public void _003C_003EiFixBaseProxy_HDNBCDEPLHP(Dictionary<string, VehicleControllerInfo> P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Explode(float P0)
	{
	}

	public void _003C_003EiFixBaseProxy_JCBIGCIKIPB()
	{
	}

	public void _003C_003EiFixBaseProxy_FIHCLADPPAF()
	{
	}

	public string _003C_003EiFixBaseProxy_GetIconInMap()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_IsLimitTimeUsage()
	{
		return false;
	}
}
