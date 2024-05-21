using System;

// 소방차 클래스.
// 필드: 소방관(운전자).
// 운전(위치-Point).
public class Firetruck
{
    // 필드.
    public Firefighter Driver { get; set; }

    // 사다리.
    private readonly Ladder ladder;

    public Firetruck()
    {
        // 10미터 길이의 사다리 생성.
        ladder = new Ladder { Length = 10f };
        Driver = null;
    }

    // 사다리를 반환하는 Getter.
    public Ladder GetLadder()
    {
        return ladder;
    }

    // 공개 위치를 지정해 운전하는 메소드.
    public void Drive(Point coordinates)
    {
        if (Driver == null)
        {
            // 바로 함수를 종료하기 보다는, 오류 메시지를 보여주는 것이 훨씬 더 좋음.
            // Silent is violent.
            return;
        }

        Console.WriteLine($"{coordinates} 위치로 소방차 이동 중.");
    }
}