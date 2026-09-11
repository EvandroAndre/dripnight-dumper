using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSProgressContainer3DController : MonoBehaviour
{
	public class ProgressNodeGo
	{
		private GameObject lockGo;

		private GameObject exploreGo;

		private GameObject completeGo;

		private UILabel lockLabel;

		private UILabel exploreLabel;

		private UILabel completeLabel;

		public ProgressNodeGo(UINinthSYSProgressNodeView view)
		{
		}

		public void SetStatus(UIModelNinthSYS.Status status)
		{
		}

		public void SetNodeValue(uint value)
		{
		}
	}

	public class NormalRewardBoxGo : UINinthSYSProgressRewardBoxGo
	{
		private GameObject m_NormalBoxIcon;

		private UINetworkTexture m_NormalBoxTexture;

		private GameObject m_OpenlBoxIcon;

		private UINetworkTexture m_OpenlBoxTexture;

		private GameObject m_AppearUIFXGo;

		private GameObject m_UnlockUIFXGo;

		private GameObject m_IconUIFXTrans;

		private bool isNormal;

		private UIModelNinthSYS.IProgress m_ProgressData;

		private bool m_IsCDNActive;

		public NormalRewardBoxGo(UINinthSYSProgressRewardBoxView view, int index)
			: base(null, 0)
		{
		}

		public void Init(UIModelNinthSYS.IProgress data)
		{
		}

		public override void Refersh()
		{
		}

		public override bool Refersh(uint val)
		{
			return false;
		}

		protected override void RefershView()
		{
		}

		public void OnDisable()
		{
		}

		public void SetCDNStatus(bool active)
		{
		}

		protected override void OnClickBoxBtn()
		{
		}

		public void _003C_003EiFixBaseProxy_RefershView()
		{
		}

		public void _003C_003EiFixBaseProxy_OnClickBoxBtn()
		{
		}
	}

	public UINinthSYSProgressRewardBoxView[] NormalProgressRewardBoxViews;

	public UINinthSYSProgressNodeView[] ProgressNodeViews;

	public UIProgressBar ProgressBar;

	public GameObject ThumbUIFXTrans;

	public GameObject GroundUIFXTrans;

	private Camera m_Camera;

	private UIModelNinthSYS m_ModelNinthSYS;

	private List<NormalRewardBoxGo> m_listProgressRewardBoxes;

	private List<ProgressNodeGo> m_listProgressNodeGos;

	private bool m_Initialized;

	private BitArrayBoolean m_IsVisible;

	private const uint NINTH_STATUE_ANIM = 1u;

	private const uint NINTH_AREA = 2u;

	private const uint LIMIT_EVENT_INFO = 4u;

	private const uint PHOTO_MODE = 8u;

	private Animation m_Animation;

	private readonly string ANIM_NAME_SHOW;

	private readonly string ANIM_NAME_HIDE;

	private uint m_AnimDelayKey;

	private int Layer3DUIMask;

	private RaycastHit hitInfo;

	private GameObject m_Pressed3DUIButtonGo;

	private Vector2 m_LastMousePosition;

	private Vector2 m_TotalMouseDelta;

	private bool m_IsClickBlockedByUI;

	private UICamera.ClickNotification m_ClickNotification;

	private const float DEFAULT_MOUSE_CLICK_THRESHOLD = 10f;

	private Camera cachedCamera => null;

	public Transform GetThumbTrans()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUIInit()
	{
	}

	private void OnUIDestory()
	{
	}

	public void OnUISceneLoaded()
	{
	}

	public void OnUISceneDestroyed()
	{
	}

	private void InitView()
	{
	}

	private void CheckPhotoModeVisible()
	{
	}

	private void Update()
	{
	}

	private void Detect3DUIButtonClick()
	{
	}

	private void Process3DUIButtonPress(Vector3 screenPosition)
	{
	}

	private void Update3DUIButtonClickState(Vector3 screenPosition)
	{
	}

	private void Process3DUIButtonRelease(Vector3 screenPosition)
	{
	}

	private GameObject Raycast3DUIButton(Vector3 screenPosition)
	{
		return null;
	}

	private float GetMouseClickThresholdSqr()
	{
		return 0f;
	}

	private void Reset3DUIButtonClick()
	{
	}

	private bool IsPointerBlockedByUI(Vector3 screenPosition)
	{
		return false;
	}

	public void SetGameObjectActive(bool active)
	{
	}

	private void RefershGameObjectActiveInternal(uint flag, bool v, bool force = false)
	{
	}

	private void OnInfoCallback()
	{
	}

	private void OnProgressStatusCallback()
	{
	}

	private void OnPhotoModeCallback(bool isVisible)
	{
	}

	public void SetGameObjectActiveByAnimation(bool active)
	{
	}

	public void ProgressValueRefersh()
	{
	}

	private void OnProgressBoxClick(int index, Vector3 position)
	{
	}

	private void _003CRefershGameObjectActiveInternal_003Eb__49_0()
	{
	}
}
