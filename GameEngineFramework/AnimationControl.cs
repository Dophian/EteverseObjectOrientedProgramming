using System;

public class AnimationControl : Component
{
    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("AnimationControl.Update()");
    }

    public override void Draw()
    {
        base.Draw();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("AnimationControl.Draw()");
    }
}