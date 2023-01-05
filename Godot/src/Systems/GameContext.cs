namespace DP.Systems;

using Godot;
using System;

public partial class GameContext : Node
{
	private readonly IChanceOrganizer _chanceOrganizer;
	private readonly ICity _city;
	private readonly IEventWizard _eventWizard;
	private readonly IFilterResolver _filterResolver;
	private readonly IGameInitializer _gameInitializer;
	private readonly IQueueCoordinator _queueCoordinator;
	private readonly IStore _store;
	private readonly ITurnContext _turnContext;
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
