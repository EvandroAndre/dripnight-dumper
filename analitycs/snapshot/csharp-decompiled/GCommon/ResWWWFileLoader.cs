using System;
using UnityEngine;

namespace GCommon;

public class ResWWWFileLoader : ResWithTimeoutFileLoader
{
	public WWW HttpWWW;

	public Action<WWW, ResWWWFileLoader> OnLoaded;

	public ResDownloadType DownloadType;

	protected override void OnStart(float time)
	{
	}

	public override bool HasStarted()
	{
		return false;
	}

	public override bool IsFinished()
	{
		return false;
	}

	protected override void OnUpdate(float time)
	{
	}

	protected override void OnDispose()
	{
	}

	protected override void OnNotify()
	{
	}
}
