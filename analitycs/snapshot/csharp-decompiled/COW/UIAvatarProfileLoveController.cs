using System;
using GCommon;

namespace COW;

public class UIAvatarProfileLoveController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIAvatarProfileLoveController _003C_003E4__this;

		public bool flag;

		internal void _003CRequestOriLove_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public UIAvatarProfileLoveController _003C_003E4__this;

		public bool flag;

		public Action _003C_003E9__1;

		internal void _003CRequestAwakenLove_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestAwakenLove_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UIAvatarProfileLoveController _003C_003E4__this;

		public bool flag;

		public Action _003C_003E9__1;

		internal void _003CRequestLove_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestLove_003Eb__1()
		{
		}
	}

	private UIAvatarProfileLoveView m_View;

	private AvatarProfile m_avatarprofile;

	private uint m_avatarid;

	private float m_curtime;

	private bool m_IsAwaken;

	private AvatarProfile m_oriavatarprofile;

	private AvatarProfile m_awakenavatarprofile;

	private uint m_oriavatarid;

	private uint m_awakenavatarid;

	protected uint m_DelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void onLoveClick()
	{
	}

	public void SetDataId(AvatarProfile profile)
	{
	}

	private void RequestOriLove(uint avatarid, bool flag)
	{
	}

	private void RequestAwakenLove(uint avatarid, bool flag)
	{
	}

	private void RequestLove(bool flag)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
