using GCommon;

namespace COW;

public class UIHudCameraTemplateItemController : UIBaseController
{
	protected UIHudCameraTemplateItemView m_View;

	protected UIHudCameraTemplatePanelController m_CameraTemplatePanel;

	protected bool isSelect;

	private CameraTemplateData _003CCameraConfigData_003Ek__BackingField;

	private VideoTemplateData _003CVideoConfigData_003Ek__BackingField;

	public CameraTemplateData CameraConfigData
	{
		get
		{
			return _003CCameraConfigData_003Ek__BackingField;
		}
		private set
		{
			_003CCameraConfigData_003Ek__BackingField = value;
		}
	}

	public VideoTemplateData VideoConfigData
	{
		get
		{
			return _003CVideoConfigData_003Ek__BackingField;
		}
		private set
		{
			_003CVideoConfigData_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public void SetUIData(CameraTemplateData config)
	{
	}

	public void SetUIData(VideoTemplateData config)
	{
	}

	public virtual void Choose()
	{
	}

	public void StartPlay()
	{
	}

	public virtual void UnChoose()
	{
	}

	private void OnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
