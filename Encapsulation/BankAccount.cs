using System;

// 잔고가 있는 은행 계좌 클래스.
public class BankAccount
{
    // 잔고 정보. (private)
    private decimal balance;

    // 생성자 (Constructor).

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    // 입금 - 메세지 (외부와 소통할 수 있는).
    public void Deposit(decimal amount)
    {
        // 입금액이 0원 이상인지 확인.
        if (amount > 0)
        {
            // 검증이 되었으면 잔고에 추가.
            balance += amount;
        }
        else
        {
            // 검증에 실패하면, 명확하게 오류를 발생시킴.
            throw new ArgumentException("입금액은 반드시 0보다 커야 합니다.");
        }
    }

    // 출금.
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            // 검증에 성공하면, 잔고를 출금액 만큼 줄이기.
            balance -= amount;
        }
        else
        {
            // 검증에 실패하면, 명확하게 오류를 발생시킴.
            throw new ArgumentException("출금액이 잘못되었습니다.");
        }
    }

    //잔고 확인 - (메세지를 통해서 소통).
    // public 메소드 → 인터페이스(Interface).
    public decimal GetBalance()
    {
        // 검증.
        if (balance < 0)
        {
            throw new Exception("잔고에 문제가 발생했습니다.");
        }

        return balance;
    }

    // 잔고를 출력하는 함수.

    public void ShowBalance()
    {
        Console.WriteLine($"잔고: {balance}원");
    }

}