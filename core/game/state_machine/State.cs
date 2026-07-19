using Godot;
using System;

public partial class State : Node
{
    public Node Parent;
    public StateMachine StateMachine;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public virtual void Enter(State previousState)
    {
    }

    public virtual void Exit()
    {
    }
}
