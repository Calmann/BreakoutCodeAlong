using Godot;
using System;

public partial class Wall : StaticBody2D {
	[Export]private Sprite2D sprite;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		sprite = GetNode<Sprite2D>("Sprite2D");
		Vector2 spriteSize = sprite.Texture.GetSize();
		Vector2 wallSize = Scale * spriteSize;
		Rect2 newRegionRect = sprite.RegionRect;
		newRegionRect.Size = wallSize;
		sprite.RegionRect = newRegionRect;
		sprite.Scale = sprite.Scale / Scale;
		base._Ready();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}
}
