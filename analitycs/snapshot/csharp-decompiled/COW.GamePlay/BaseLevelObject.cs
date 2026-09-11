using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public abstract class BaseLevelObject : COWReplicationEntity, IBridgingEntity, CNMHJGNKOOF, HDIAOJDIPII, FDACAOPGNJK
{
	public string ModelResName;

	private ResourceID GAMNPMNLAGK;

	protected BitArrayBoolean PIFIFGEGFDE;

	protected const uint GCKMBDPLDHP = 1u;

	protected const uint OJHIAEHOGIL = 16777216u;

	protected const uint EGFHDNGJLNA = 33554432u;

	protected const uint DPLMBGANJBK = 67108864u;

	public const uint ISVISIBLE_CUSTOM4 = 134217728u;

	public const uint ISVISIBLE_CUSTOM3 = 268435456u;

	public const uint ISVISIBLE_CUSTOM2 = 536870912u;

	public const uint ISVISIBLE_CUSTOM1 = 1073741824u;

	private GameObject _003CFEEAABJICGB_003Ek__BackingField;

	private bool _003CCMGNOBIAOLH_003Ek__BackingField;

	protected BaseLevelObject NLJOGBCGHAI;

	protected List<BaseLevelObject> BIGDDOJBIBD;

	public bool NeedAsyncLoad;

	private ResourceManager.LoadPriority KLPBJKBLOPK;

	protected uint HCIJILKGKBP;

	protected bool EGEILIAGGPH;

	protected OPICPDCLKAG CPNJPAELLCO;

	protected uint KFMNLPAHBJA;

	protected string m_UGCEntityID;

	internal UGCAimAssistEntity EDNNCNHMCOJ;

	private UGCPlayableController OBKEHFNMKAJ;

	private string _003CPNDBLGCDFKL_003Ek__BackingField;

	public bool IsUGCStatic;

	public bool FromStaticSubLevel;

	public const int DEFAULT_VISIBILITYLAYER = 0;

	private SceneEditObjectSetScale AMAFILECCJI;

	protected bool HKKFJAABPAA;

	protected Quaternion PAOEFBNOJIM;

	protected bool KABGMJDICKA;

	protected bool HHCMICDHKNJ;

	protected bool HONOLJLBACL;

	public uint m_PlatformID;

	public Vector3 m_LocalPositionOnPlatform;

	public Quaternion m_LocalRotationOnPlatform;

	protected ResourceID JBHLGJBOGBK
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	protected GameObject GNPADMJNFEA
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool KMICJGMGLKF
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	protected virtual Transform DJDHMIGFFCE => null;

	public virtual GameObject AFLBHFDFEAB => null;

	public OPICPDCLKAG GIDOCBCIOMC
	{
		get
		{
			return OPICPDCLKAG.Invalid;
		}
		set
		{
		}
	}

	public uint KPAHHAACNKP
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string AJMEEOHBMDO
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private FJEEGHOAKOG PJMGHEELAMN => null;

	protected COW.GamePlay.UGCRuntime.UGCRuntime GPFKOFAJJMH => null;

	public string IOEMGDBBNNF
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual void OnUGCEntityCreated(string GDDEBLAFLLG, string JGJPIGFEFEG)
	{
	}

	protected virtual void SetRigidbody4ClientEntity(string GDDEBLAFLLG, string JGJPIGFEFEG)
	{
	}

	protected void HJOHHEJKPMC(BaseLevelObject BFPGAHNNPOH)
	{
	}

	protected void IGCIHOGNOMK(BaseLevelObject BFPGAHNNPOH)
	{
	}

	private void OnCollisionEnter(Collision MKPLDLFKAIK)
	{
	}

	public void SetAsyncLoadPriority(ResourceManager.LoadPriority GKMFJPIEFGH)
	{
	}

	private void OnCollisionExit(Collision MKPLDLFKAIK)
	{
	}

	public virtual void SetUGCStatic(bool AKNONFMNKCD)
	{
	}

	private void AOPDDMFGNNM()
	{
	}

	public virtual void OnExtraRenderLayerChanged()
	{
	}

	public virtual void OnSyncUGCEntityProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	public virtual void OnMove()
	{
	}

	public virtual void OnScale()
	{
	}

	private void GIDJACNPFML(bool KGOHDEBHENF)
	{
	}

	public void SetSubLevelStreamingVisible(bool KGOHDEBHENF)
	{
	}

	public void RefreshVisibleStateByCurrentStreamer()
	{
	}

	public void RefreshLocalViewerVisibility()
	{
	}

	protected void EHJIFJDJAAE()
	{
	}

	public void UGCUpdatePropertyForCombine(long OGDNBBJKNFD, object EIOKHLKJEEL)
	{
	}

	public virtual bool CreateDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	public virtual bool RemoveDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	protected void GGFOLEMLPKK(string GDDEBLAFLLG)
	{
	}

	string CNMHJGNKOOF.UGCEntityID()
	{
		return null;
	}

	string CNMHJGNKOOF.UGCArchTypeID()
	{
		return null;
	}

	bool CNMHJGNKOOF.IsStatic()
	{
		return false;
	}

	int IBridgingEntity.BridgingTypeID()
	{
		return 0;
	}

	string IBridgingEntity.UGCEntityID()
	{
		return null;
	}

	void IBridgingEntity.OnLogicEntityCreated(string GDDEBLAFLLG)
	{
	}

	IUGCValue IBridgingEntity.BridgingPropGetter(long DLOFKFKIMGC)
	{
		return null;
	}

	bool IBridgingEntity.BridgingPropSetter(long DLOFKFKIMGC, UGCSimpleValue GPFPIAMCEMI)
	{
		return false;
	}

	public void RefreshUGCPhysicalLayer()
	{
	}

	private void IMIDLHKLOCA(int JMJLJKEELMO, bool IAGGIPADFFL)
	{
	}

	protected virtual bool MBOOIGIPJDG()
	{
		return false;
	}

	public Vector3 ProcessRotation()
	{
		return default(Vector3);
	}

	public virtual void UpdateAimRotation()
	{
	}

	protected abstract string GetObjectTag();

	protected virtual void HIKJFHMNPJA()
	{
	}

	public string GetObjectName()
	{
		return null;
	}

	public uint GetObjectID()
	{
		return 0u;
	}

	public virtual string GetOverrideMarkIconResName()
	{
		return null;
	}

	public virtual ResourceID GetOverrideMarkIconResId()
	{
		return default(ResourceID);
	}

	public virtual void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public virtual void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	protected override void OnStart()
	{
	}

	public override void OnRecycle()
	{
	}

	public override void OnRecycleClearData()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected override void OnOnDestroy()
	{
	}

	protected virtual void PreRegister()
	{
	}

	public virtual void RegisterThis(OPICPDCLKAG CCNBNLAPJFM, uint LIKPJDHGPFG)
	{
	}

	public void UnRegisterThis()
	{
	}

	protected void PGIAIOAJBJA()
	{
	}

	public override void InitEntityInfo()
	{
	}

	public new virtual void Hide()
	{
	}

	public virtual void Show(bool PIDINBNGILH)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public virtual void TakeDamage(int FCAOOKIBKJK)
	{
	}

	public virtual void TakeDamage(BHGGAEEHJCO OBMFMAKFDDL, Vector3 KHNFEFFKMEB)
	{
	}

	public virtual void TakeHealing(int AKECMLNMBEO, BHGGAEEHJCO AEBLLNMKKIC, int CBNGGHHMPHA, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null)
	{
	}

	protected virtual void OnModelShowed()
	{
	}

	protected virtual void JHEFLJNCBPJ()
	{
	}

	protected virtual void GHHGKFJIEFC()
	{
	}

	protected virtual void OPDFOLOPHBB()
	{
	}

	protected void AIJKLGJMHFG(uint GGAOIPIHOBP, bool CPBHKACJHLG, Object HACIJIFIDKM)
	{
	}

	protected virtual void FLFHMOGHICH(bool GMLCCOIKJGD)
	{
	}

	protected void HNKHOBJPHOO()
	{
	}

	protected void DKCKCDALABC(ResourceID HDIFABKLGIC)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	public bool GetFinalVisibility(bool IJMKBLBPKKP = false)
	{
		return false;
	}

	public virtual void OnCameraCullingMaskChanged()
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

	public void EnterMovePlatformByID(uint NBINOHHBLJC, Vector3 AEHDKGGIACO, Quaternion BKLJADMKMGN)
	{
	}

	public void EnterMovePlatformByID(uint NBINOHHBLJC, Vector3 AEHDKGGIACO)
	{
	}

	public void EnterMovePlatformByID(uint NBINOHHBLJC)
	{
	}

	public void EnterMovePlatform(LevelMovePlatform KOBNLELKJLD, Vector3 AEHDKGGIACO, Quaternion BKLJADMKMGN)
	{
	}

	public void EnterMovePlatform(LevelMovePlatform EEGHANDKINF)
	{
	}

	public void TryEnterMovePlatform(GameObject PFJFADHEJLJ)
	{
	}

	protected virtual void HEFADOLBNHP()
	{
	}

	public virtual string GetBotAgentRuntimeData()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnRecycleClearData()
	{
	}

	public void _003C_003EiFixBaseProxy_InitEntityInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
