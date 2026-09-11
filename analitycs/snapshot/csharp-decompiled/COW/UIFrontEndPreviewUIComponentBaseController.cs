using GCommon;

namespace COW;

public abstract class UIFrontEndPreviewUIComponentBaseController : UIBaseController
{
	protected FrontEndPreviewUIConfigData m_FrontEndPreviewUIConfigData;

	protected FrontEndPreviewConfigData m_FrontEndPreviewConfigData;

	protected FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private uint _003CCurrentItemID_003Ek__BackingField;

	private uint _003CShowItemID_003Ek__BackingField;

	public uint CurrentItemID
	{
		get
		{
			return _003CCurrentItemID_003Ek__BackingField;
		}
		set
		{
			_003CCurrentItemID_003Ek__BackingField = value;
		}
	}

	public uint ShowItemID
	{
		get
		{
			return _003CShowItemID_003Ek__BackingField;
		}
		set
		{
			_003CShowItemID_003Ek__BackingField = value;
		}
	}

	protected abstract void InitBaseUIView();

	protected virtual void InitView()
	{
	}

	public void SetFrontEndPreviewUIConfigData(FrontEndPreviewUIConfigData uiData, FrontEndPreviewConfigData data)
	{
	}

	protected virtual void OnSetFrontEndPreviewUIConfigData()
	{
	}

	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent component)
	{
	}

	protected virtual void OnSetFrontEndPreviewComponent()
	{
	}

	public virtual int GetAdditionalDepthOnPopWnd()
	{
		return 0;
	}
}
