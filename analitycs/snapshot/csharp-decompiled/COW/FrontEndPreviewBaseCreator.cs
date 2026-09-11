using GCommon;
using UnityEngine;

namespace COW;

public class FrontEndPreviewBaseCreator
{
	protected bool m_HasExamplePreviewPos;

	protected float modelPosX;

	protected bool m_UseCenterPreviewPos;

	protected float examplePreviewModelPosX;

	protected float ModelPosY;

	private FrontendPreviewType _003CPreviewType_003Ek__BackingField;

	protected UIBaseController m_ParentController;

	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	protected FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	protected FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	protected UIWidget m_PreviewBorder;

	protected FrontEndPreviewContentCreator m_ContentCreator;

	protected FrontEndPreviewComponent.Cameratype m_Cameratype;

	protected Camera m_Camera;

	protected GameObject m_CameraGo;

	protected PreviewCameraMove m_CameraMove;

	protected GameObject m_Preview3DItem;

	protected GameObject m_GroundShadow;

	protected UIModelAvatar m_ModelAvatar;

	protected UIModelHyperBook m_ModelHyperBook;

	protected UIModelTailor m_ModelTailor;

	private int m_Degree360PreviewItemReadyFlag;

	protected int Degree360PreviewItemAllReady;

	protected float ModelPosX
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected float ExamplePreviewModelPosX
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public FrontendPreviewType PreviewType
	{
		get
		{
			return _003CPreviewType_003Ek__BackingField;
		}
		set
		{
			_003CPreviewType_003Ek__BackingField = value;
		}
	}

	public Camera Camera => null;

	public GameObject CameraGo => null;

	public GameObject Preview3DItem => null;

	protected int Degree360PreviewItemReadyFlag
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual void Init(FrontEndPreviewComponent comp, UIBaseController parentCtrl, FrontEndPreviewContentCreator creator, GameObject groundShadow)
	{
	}

	public virtual void SetPreviewMoveBg(UITexture tex)
	{
	}

	public void SetPreviewBorder(UIWidget previewBorder)
	{
	}

	public virtual void OnTempHidePreview()
	{
	}

	public virtual void OnClosePreview()
	{
	}

	protected virtual FrontEndPreviewComponent.Cameratype GetPreviewCameratype()
	{
		return FrontEndPreviewComponent.Cameratype.None;
	}

	public void SetPreview3dItemEnable(bool enable)
	{
	}

	public void ClearPreview3DItem()
	{
	}

	public virtual void OnSwitchCamera(FrontEndPreviewComponent.Cameratype type)
	{
	}

	public void ResetCamera()
	{
	}

	public virtual void CloseCamera()
	{
	}

	public void SetGroundShadowPos(Vector3 pos)
	{
	}

	public void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, bool calculateYPos = false, float scaley = 0.5f, bool isAvatar = false, bool calcaulateCenterPriviewAnchorPoint = true, float offsetX = 0f)
	{
	}

	public void AutoModifyPreviewModelAccordingToResolution(ref GameObject go, GameObject boxGo, bool calculateYPos = false, float scaley = 0.5f, bool isAvatar = false, bool calcaulateCenterPriviewAnchorPoint = true)
	{
	}

	protected virtual void AutoShift3DPreview(ref GameObject go, float scalex, float scaley, bool useY, bool calcaulateCenterPriviewAnchorPoint = true, float offsetX = 0f)
	{
	}

	private void AutoGen3DPreviewCollider(GameObject go, bool isAvatar = false)
	{
	}

	protected bool CheckInvaildCollider(Renderer render)
	{
		return false;
	}

	protected void SetCameraFovAccordingToResolution(Camera camera)
	{
	}

	public void SetModelPos(float modelPosX, float modelPosY)
	{
	}

	public void ResetExamplePreviewState()
	{
	}

	public void SetExamplePreviewModelPosX(float x, bool setPan = false)
	{
	}

	protected void InJectPreviewComponentToScript(GameObject go)
	{
	}
}
