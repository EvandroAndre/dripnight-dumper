using UnityEngine;

namespace GooglePlayInstant;

public static class PlaySignatureVerifier
{
	private static readonly byte[] GooglePlayPackageSignature;

	public static bool VerifyGooglePlayServices(AndroidJavaObject packageManager)
	{
		return false;
	}

	private static bool VerifyGooglePlayPackage(AndroidJavaObject packageManager, string packageName)
	{
		return false;
	}
}
