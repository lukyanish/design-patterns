namespace design_patterns.creational.abstract_factory;

public class WindowsDialog: Dialog
{
    protected override IButton CreateButton()
    {
        return new WindowsButton();
    }
}