using System;
using System.Collections.Generic;

namespace COW;

public abstract class PhotoBgDataContainer
{
	protected List<PhotoBackGroundData> m_BackGroundDatas;

	public abstract void RequestData(Action<bool> callback = null);

	public abstract void OnSelectBackground(PhotoBackGroundData bgData);

	public abstract void ClearData();

	public List<PhotoBackGroundData> GetBackgroundDatas()
	{
		return null;
	}

	public virtual Type GetBigEventBgItemController()
	{
		return null;
	}

	public virtual string GetFormatPhotoBgTimeStamp()
	{
		return null;
	}

	public virtual bool IsPhotoBgTabFirstClicked()
	{
		return false;
	}

	public virtual void MarkPhotoBgTabAsFirstClicked()
	{
	}

	public virtual bool IsUnlockPhotoBgTab()
	{
		return false;
	}

	public virtual bool ShouldShowPhotoBgTabRedDot()
	{
		return false;
	}

	public virtual void MarkPhotoBgTabAsClicked()
	{
	}

	public virtual void SetNavigateFromPhotoBg(bool shouldReturn)
	{
	}

	public virtual bool GetAndClearNavigateFromPhotoBg()
	{
		return false;
	}
}
