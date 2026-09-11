namespace GCommon;

internal interface IEntityTicker
{
	void OnFixedUpdate(float gameTime, float deltaTime);

	void OnUpdate(float gameTime, float deltaTime);

	void OnPaused();

	void OnResumed();
}
