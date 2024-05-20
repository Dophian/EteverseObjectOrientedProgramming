using System;

public class GameObject
{
    // 컴포넌트 배열.
    private List<Component> components;

    public GameObject()
    {
        components = new List<Component>();
    }

    // 컴포넌트를 추가하는 메소드.
    public void AddComponent(Component component)
    {
        components.Add(component);
    }

    public void Update(float deltaTime)
    {
        foreach (Component component in components)
        {
            component.Update(deltaTime);
        }
    }

    // 화면을 그리는 메소드.
    public void Draw()
    {
        foreach (Component component in components)
        {
            component.Draw();
        }
    }
}