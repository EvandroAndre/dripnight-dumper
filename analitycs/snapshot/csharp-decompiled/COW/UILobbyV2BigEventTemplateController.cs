using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILobbyV2BigEventTemplateController : UIBaseController, IBigEventTemplateLobbyIconBanner
{
	public enum EntranceLocation
	{
		None,
		BigEvent,
		RevBtn
	}

	private UILobbyNewEventBigEventTemplateView m_View;

	private UICountDownController m_BigEventTemplateCountDownCtrl;

	private UINewDownloadInfoController m_BigEventTemplateEntranceDownloadCtrl;

	private UITipsNormalController m_RedTipsCtrl;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private float m_NextCheckTime;

	private ResourceID m_BigEventTemplateEntranceEffectVFXResID;

	private GameObject m_BigEventTemplateEntranceEffectVFXGO;

	private EBigEventTemplateUseType m_TemplateUseType;

	private EntranceLocation m_EntranceLocation;

	private BigEventTemplateLobbyIconBannerStatus _003CBannerStatus_003Ek__BackingField;

	private GameObject m_FlyEffectGo;

	private GameObject m_BannerAppearEffectGo;

	private GameObject m_BannerDisappearEffectGo;

	private readonly float FlyDuration;

	private readonly string BannerAnimInLeft;

	private readonly string BannerAnimOutLeft;

	private float OpenedDuration;

	private float m_CurrentExecuteStatusPoint;

	private Vector3 m_FlyStartPoint;

	private Vector3 m_ControlPoint;

	private bool m_FlyComplete;

	private CustomEventLobbyIconDesc m_LobbyIconDesc;

	private uint m_BannerAnimKey;

	private Transform BigEventTemplateBannerEffect;

	private UILabel BigEventTemplateBannerLabel;

	private UINetworkTexture BigEventTemplateBannerTexture;

	private UISprite BigEventTemplateBannerSprite;

	private Animation BigEventTemplateBannerAnimation;

	private string BigEventTemplateBannerAnimIn;

	private string BigEventTemplateBannerAnimOut;

	public BigEventTemplateLobbyIconBannerStatus BannerStatus
	{
		get
		{
			return _003CBannerStatus_003Ek__BackingField;
		}
		private set
		{
			_003CBannerStatus_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickBtnBigEventTemplate()
	{
	}

	protected bool IsDurningWarmupTime()
	{
		return false;
	}

	private void InitBtnBigEventTemplateClickSound()
	{
	}

	public void UpdateBigEventTemplateEntrance(int entranceLocation)
	{
	}

	public void RefreshTemplateBigEventEntranceDownloadState()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void ResetTipsContainer(bool isShow)
	{
	}

	public void ResetBigEventTemplateEntranceIntro()
	{
	}

	public bool RefreshBigEventTemplateEntranceIntro()
	{
		return false;
	}

	public void SetTemplateUseType(EBigEventTemplateUseType useType)
	{
	}

	protected void OnSetImageTextureSuccess()
	{
	}

	public void PlayFlyEffect(CustomEventLobbyIconDesc desc, Vector3 position)
	{
	}

	private void ClearBannerData()
	{
	}

	private void RefershBannerContainer()
	{
	}

	private void InitBanner()
	{
	}

	private void ExecuteFlyStatus()
	{
	}

	private Vector3 GetPosByBezierCurve(float t, Vector3 endPoint)
	{
		return default(Vector3);
	}

	private void ExecuteBannerOpeningStatus()
	{
	}

	private void ExecuteBannerOpenedStatus()
	{
	}

	private void ExecuteBannerClosingStatus()
	{
	}

	private GameObject CreateEffectGo(string res_id, Transform parent)
	{
		return null;
	}

	private bool PlayAnim(Animation anim, string strAnim, out float length)
	{
		length = default(float);
		return false;
	}

	private void _003CUpdateBigEventTemplateEntrance_003Eb__17_0()
	{
	}

	private void _003CExecuteBannerOpeningStatus_003Eb__56_0()
	{
	}

	private void _003CExecuteBannerClosingStatus_003Eb__58_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
