using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIActivityMasterController : UIActivityPopWindowBase, IUIModelDataChangeObserver
{
	public enum ActivityCategory
	{
		None,
		Activity,
		Announcement,
		SignIn,
		EPChallenge,
		FestivalActivity1,
		FestivalActivity2,
		MegaFestival,
		NewAnnouncement,
		FestivalActivity3,
		ReleaseNotes,
		ReturnFeatures,
		EsportsCalendar
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<ActivityGroupDesc> _003C_003E9__25_0;

		internal bool _003CGetTabPriority_003Eb__25_0(ActivityGroupDesc e)
		{
			return false;
		}
	}

	private sealed class _003CWaitInitHttpRequest_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HttpRequest request;

		public bool waitEsportsWebRequest;

		public UIActivityMasterController _003C_003E4__this;

		private UIWaitingForRequestCircleController _003CuiLoadingController_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitInitHttpRequest_003Ed__13(int _003C_003E1__state)
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

	private UIModelActivity m_ModelActivity;

	private UIModelAnnouncement m_ModelAnnouncement;

	private UIModelFriendReunion m_ModelFriendReunion;

	private IEnumerator m_WaitInitHttpRequest;

	private string m_TabPath;

	private UINavigationUtil.UINavigationFrom m_UGCCenterReturnTo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnContentChanged(object[] data)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void SetUGCCenterReturnTo(UINavigationUtil.UINavigationFrom returnTo)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private IEnumerator WaitInitHttpRequest(HttpRequest request, bool waitEsportsWebRequest)
	{
		return null;
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void PrepareTopTabData()
	{
	}

	protected override int GetDefaultTabIndex()
	{
		return 0;
	}

	private int CompareDefaultCategoryInfo(CategoryTabData aTabData, CategoryTabData bTabData)
	{
		return 0;
	}

	private int CompareCategoryInfo(CategoryTabData aTabData, CategoryTabData bTabData)
	{
		return 0;
	}

	private static ulong ParseFestivalStartTime(string rawStartTime)
	{
		return 0uL;
	}

	private CategoryTabData PrepareActivityFestival(EventTabType festivalType)
	{
		return null;
	}

	private CategoryTabData PrepareFeatures()
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override int GetTabPriority(CategoryTabData tabData)
	{
		return 0;
	}

	private UIActivityBaseController _003CPrepareTopTabData_003Eb__16_0()
	{
		return null;
	}

	private UIActivityBaseController _003CPrepareTopTabData_003Eb__16_1()
	{
		return null;
	}

	private UIActivityBaseController _003CPrepareActivityFestival_003Eb__21_0()
	{
		return null;
	}

	private UIActivityBaseController _003CPrepareFeatures_003Eb__22_0()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_PrepareTopTabData()
	{
	}

	public int _003C_003EiFixBaseProxy_GetDefaultTabIndex()
	{
		return 0;
	}

	public int _003C_003EiFixBaseProxy_GetTabPriority(CategoryTabData P0)
	{
		return 0;
	}
}
