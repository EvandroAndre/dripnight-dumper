using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITakePhotoGroupTemplateVerticalController : UITakePhotoGroupTemplateBaseController
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public uint templateId;

		internal bool _003CRefreshTemplateList_003Eb__0(GroupPhotoTemplateData x)
		{
			return false;
		}
	}

	private sealed class _003CRefreshTemplateList_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint templateId;

		public UITakePhotoGroupTemplateVerticalController _003C_003E4__this;

		public List<GroupPhotoTemplateData> list;

		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshTemplateList_003Ed__7(int _003C_003E1__state)
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

	private UITakePhotoGroupTemplateVerticalView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override UIEasyListItemController OpenItemControllerInteral(Transform parent)
	{
		return null;
	}

	protected override void InitView()
	{
	}

	protected override string GetExpandAnimStr(bool isExpand)
	{
		return null;
	}

	public override void SetData(List<GroupPhotoTemplateData> list, uint templateId = 0u, uint templateType = 0u)
	{
	}

	private IEnumerator RefreshTemplateList(List<GroupPhotoTemplateData> list, uint templateId)
	{
		return null;
	}

	public void SetPanelDepth(int depth)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(List<GroupPhotoTemplateData> P0, uint P1, uint P2)
	{
	}
}
