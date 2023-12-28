namespace design_patterns.creational.abstract_factory;

public class HtmlButton: IButton
{
    public string Render()
    {
        return "HtmlButton";
    }

    public void OnClick(Func action)
    {
        action();
    }
}