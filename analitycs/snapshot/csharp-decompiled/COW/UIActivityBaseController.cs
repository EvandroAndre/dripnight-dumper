using System;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIActivityBaseController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<UIPanel, int> _003C_003E9__7_0;

		internal int _003CFixPanelDepth_003Eb__7_0(UIPanel e)
		{
			return 0;
		}
	}

	public virtual uint GetCurrentSelectedGroupId()
	{
		return 0u;
	}

	public override void Show()
	{
	}

	public virtual void SetData(object data)
	{
	}

	public virtual void SelectItem(uint id, bool needScroll = true)
	{
	}

	public virtual void OnPanelDepthChanged()
	{
	}

	public virtual void Reload()
	{
	}

	public virtual void RefreshLeftTabData(object data)
	{
	}

	protected void FixPanelDepth(GameObject target, int baseDepth)
	{
	}

	public virtual void OnPopUpWindowListChange(bool isCovered)
	{
	}

	public virtual void OnVisibilityChange(bool isVisible)
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
