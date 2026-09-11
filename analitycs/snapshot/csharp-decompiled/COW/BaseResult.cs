using System;

namespace COW;

[Serializable]
public class BaseResult
{
	public VodkaErrorCode resultCode;

	public string message;

	public string Description => null;

	public override string ToString()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
