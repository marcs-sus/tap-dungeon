using Godot;
using System;

public partial class ExplorationState : State
{
    [Export] State CombatState;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public override void Enter(State previousState)
    {
        CombatState.Enter(previousState);
    }

    public override void Exit()
    {
        CombatState.Exit();
    }
}
