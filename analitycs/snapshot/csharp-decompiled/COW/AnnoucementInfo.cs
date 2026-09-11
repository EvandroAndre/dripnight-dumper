using System;
using proto;

namespace COW;

public class AnnoucementInfo : IComparable<AnnoucementInfo>
{
	public AnnouncementDesc Data;

	public EEventTag EventTagType;

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public int CompareTo(AnnoucementInfo other)
	{
		return 0;
	}

	public static implicit operator AnnoucementInfo(AnnouncementDesc data)
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}
}
