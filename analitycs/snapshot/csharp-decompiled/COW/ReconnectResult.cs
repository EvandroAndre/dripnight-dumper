using System;

namespace COW;

[Serializable]
public class ReconnectResult : BaseResult
{
	public int retryCount;

	public int maxRetryCount;
}
