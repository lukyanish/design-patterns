namespace design_patterns.creational.abstract_factory;

public class HtmlDialog: Dialog
{
    protected override IButton CreateButton()
    {
        return new HtmlButton();
    }
}