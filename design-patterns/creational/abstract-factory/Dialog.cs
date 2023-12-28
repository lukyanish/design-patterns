namespace design_patterns.creational.abstract_factory;

public abstract class Dialog
{
    public void Render()
    {
        var okButton = CreateButton();
        okButton.OnClick(() => Console.WriteLine("Ok button clicked"));
        okButton.Render();
    }

    protected abstract IButton CreateButton();
}