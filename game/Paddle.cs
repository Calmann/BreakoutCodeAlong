using Godot;
using System;

public partial class Paddle : CharacterBody2D {
	[Export] private int speed = 750;

	public override void _PhysicsProcess(double delta) {
		Vector2 moveDirection = Vector2.Zero;
		if(Input.IsActionPressed("ui_left")) { 
			moveDirection.X--;
		}
		if(Input.IsActionPressed("ui_right")) { 
			moveDirection.X++;
		}
		MoveAndCollide(moveDirection * speed * (float)delta);
		base._PhysicsProcess(delta);
	}
}
