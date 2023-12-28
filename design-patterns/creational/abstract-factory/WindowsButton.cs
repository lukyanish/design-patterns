namespace design_patterns.creational.abstract_factory;

public class WindowsButton: IButton
{
    public string Render()
    {
        return "WindowsButton";
    }

    public void OnClick(Func action)
    {
        action();
    }
}