using Godot;
using System;

public partial class TimerBar : Control
{
    [Export] public PackedScene SegmentScene;
    [Export] public float WaitTimer;
    [Export] public uint Length;

    private Timer timer => GetNode<Timer>("Timer");
    private Control arrow => GetNode<Control>("Arrow");
    private Container segmentContainer => GetNode<Container>("SegmentContainer");

    private bool timerFlip;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        timer.WaitTime = WaitTimer;
        timer.Start();
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    public void AddSegment(TimerSegment segment)
    {
        segmentContainer.AddChild(segment);
    }

    public void RemoveSegment(TimerSegment segment)
    {
        segmentContainer.RemoveChild(segment);
    }

    private void _OnTimerTimeout()
    {
        timerFlip = !timerFlip;
    }
}
