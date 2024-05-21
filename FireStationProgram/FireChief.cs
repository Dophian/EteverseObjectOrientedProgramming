using System;

// 소방서장 클래스.
// 소방관이면서 다른 소방관에게 불을 끄도록 지시할 수 있는 권한이 추가됨.
public class FireChief : Firefighter
{
    // 필드 - 1순위 소방관. 
    public Firefighter NumberOne {  get; set; }

    // 불끄기 함수.
    public override void ExtinguishFire()
    {
        //Console.WriteLine($"{Name} 소방관이 불을 끄고 있습니다.");
        // 직접 불을 끄는 대신, 1순위 소방관에게 불끄도록 지시한다.
        TellFirefighterToExtinguishFire(NumberOne);
    }

    // 공개 - 다른 소방관에게 불을끄라고 지시하는 메소드(인터페이스).
    // 관계 - 의존(Dependency) - 메소드 호출할 때 Firefighter를 전달받고 기능을 사용함.
    public void TellFirefighterToExtinguishFire(Firefighter colleague)
    {
        colleague.ExtinguishFire();
    }
}