using System;

// 소방서 기반(부모) 클래스.
public abstract class FirefighterBase : INamedPerson
{
    // 필드(Field) - 변수/프로퍼티.
    public string Name { get; set; }

    // 추상 메소드 - 이 클래스를 상속하는 자손 클래스에서 꼭 구현을 재정의해야하는 메소드.
    public abstract void ExtinguishFire();

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