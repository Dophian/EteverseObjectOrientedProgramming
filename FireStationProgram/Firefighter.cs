using System;

// 소방관 클래스.
// 불을 끌 수 있음.
// 소방차를 운전할 수 있음.
// 필드: 이름.
public class Firefighter
{
    // 필드(Field) - 변수/프로퍼티.
    public string Name { get; set; }

    // 공개 불끄기 메소드 - 인터페이스(interface).
    
    public virtual void ExtinguishFire()
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
    // 공개 소방차 운전 메소드 - 인터페이스(interface).
    public void Drive(Firetruck truckToDrive, Point coordinates)
    {
        // 검증 - 내가 운전할 수 있는 트럭인지 확인.
        if (truckToDrive.Driver != this)
        {
            // 트럭의 운전자가 내가 아니면 이 트럭을 운전할 수 없음.
            // Silent is violent.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} 소방관은 이 트럭의 운전자가 아니여서 운전이 불가능합니다.");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        // 트럭을 전달 받은 좌표로 이동(운전).
        truckToDrive.Drive(coordinates);
    }
}