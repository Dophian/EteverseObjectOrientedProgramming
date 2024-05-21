using System;

// 소방관 클래스.
// 불을 끌 수 있음.
// 소방차를 운전할 수 있음.
// 필드: 이름.
public class Firefighter : FirefighterBase
{
    // 공개 불끄기 메소드 - 인터페이스(interface).   
    public override void ExtinguishFire()
    {
        Console.WriteLine($"{Name} 소방관이 불을 끄고 있습니다.");
        TrainHoseOnFire();
        TurnOnHose();
    }

    protected virtual void TurnOnHose()
    {
        Console.WriteLine("불이 완전히 꺼졌습니다.");
    }

    protected virtual void TrainHoseOnFire()
    {
        Console.WriteLine("호스를 불에 조준.");
    }
}